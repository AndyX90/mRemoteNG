﻿using mRemoteNG.Config;
using mRemoteNG.Config.Serializers.CredentialSerializer;
using mRemoteNG.Config.Serializers.Xml;
using mRemoteNG.Connection;
using mRemoteNG.Container;
using mRemoteNG.Security;
using mRemoteNG.Security.Factories;
using mRemoteNG.Tree.Root;
using NUnit.Framework;
using System;
using System.Linq;
using System.Security;
using System.Xml.Linq;
using mRemoteNG.Config.Serializers.ConnectionSerializers.Xml;


namespace mRemoteNGTests.Config
{
    public class CredentialHarvesterTests
    {
        private CredentialHarvester _credentialHarvester;
        private ICryptographyProvider _cryptographyProvider;
        private readonly SecureString _key = "testKey123".ConvertToSecureString();

        [SetUp]
        public void Setup()
        {
            _credentialHarvester = new CredentialHarvester();
            _cryptographyProvider = new CryptoProviderFactory(BlockCipherEngines.AES, BlockCipherModes.GCM).Build();
        }

        [Test]
        public void HarvestsUsername()
        {
            var connection = new ConnectionInfo { Username = "myuser", Domain = "somedomain", Password = "mypass" };
            var xdoc = CreateTestData(connection);
            var harvestConfig = BuildHarvestConfig(xdoc);
            var credentials = _credentialHarvester.Harvest(harvestConfig);
            Assert.That(credentials.DistinctCredentialRecords.Single().Username, Is.EqualTo(connection.Username));
        }

        [Test]
        public void HarvestsDomain()
        {
            var connection = new ConnectionInfo { Username = "myuser", Domain = "somedomain", Password = "mypass" };
            var xdoc = CreateTestData(connection);
            var harvestConfig = BuildHarvestConfig(xdoc);
            var credentials = _credentialHarvester.Harvest(harvestConfig);
            Assert.That(credentials.DistinctCredentialRecords.Single().Domain, Is.EqualTo(connection.Domain));
        }

        [Test]
        public void HarvestsPassword()
        {
            var connection = new ConnectionInfo { Username = "myuser", Domain = "somedomain", Password = "mypass" };
            var xdoc = CreateTestData(connection);
            var harvestConfig = BuildHarvestConfig(xdoc);
            var credentials = _credentialHarvester.Harvest(harvestConfig);
            Assert.That(credentials.DistinctCredentialRecords.Single().Password.ConvertToUnsecureString(), Is.EqualTo(connection.Password));
        }

        [Test]
        public void DoesNotHarvestEmptyCredentials()
        {
            var connection = new ConnectionInfo();
            var xdoc = CreateTestData(connection);
            var harvestConfig = BuildHarvestConfig(xdoc);
            var credentials = _credentialHarvester.Harvest(harvestConfig);
            Assert.That(credentials.Count, Is.EqualTo(0));
        }

        [Test]
        public void HarvestsAllCredentials()
        {
            var container = new ContainerInfo();
            var con1 = new ConnectionInfo {Username = "blah"};
            var con2 = new ConnectionInfo {Username = "something"};
            container.AddChildRange(new [] {con1, con2});
            var xdoc = CreateTestData(container);
            var harvestConfig = BuildHarvestConfig(xdoc);
            var credentials = _credentialHarvester.Harvest(harvestConfig);
            Assert.That(credentials.Count, Is.EqualTo(2));
        }

        [Test]
        public void OnlyReturnsUniqueCredentials()
        {
            var container = new ContainerInfo();
            var con1 = new ConnectionInfo { Username = "something" };
            var con2 = new ConnectionInfo { Username = "something" };
            container.AddChildRange(new[] { con1, con2 });
            var xdoc = CreateTestData(container);
            var harvestConfig = BuildHarvestConfig(xdoc);
            var credentials = _credentialHarvester.Harvest(harvestConfig);
            Assert.That(credentials.DistinctCredentialRecords.Count, Is.EqualTo(1));
        }

        [Test]
        public void CredentialMapCorrectForSingleCredential()
        {
            var connection = new ConnectionInfo { Username = "myuser", Domain = "somedomain", Password = "mypass" };
            var connectionGuid = Guid.Parse(connection.ConstantID);
            var xdoc = CreateTestData(connection);
            var harvestConfig = BuildHarvestConfig(xdoc);
            var map = _credentialHarvester.Harvest(harvestConfig);
            Assert.That(map[connectionGuid].Username, Is.EqualTo(connection.Username));
        }

        [Test]
        public void CredentialMapDoesntContainDuplicateCredentialObjects()
        {
            var container = new ContainerInfo();
            var con1 = new ConnectionInfo { Username = "something" };
            var con2 = new ConnectionInfo { Username = "something" };
            container.AddChildRange(new[] { con1, con2 });
            var xdoc = CreateTestData(container);
            var con1Id = Guid.Parse(con1.ConstantID);
            var con2Id = Guid.Parse(con2.ConstantID);
            var harvestConfig = BuildHarvestConfig(xdoc);
            var map = _credentialHarvester.Harvest(harvestConfig);
            Assert.That(map[con1Id], Is.EqualTo(map[con2Id]));
        }


        private XDocument CreateTestData(ConnectionInfo connectionInfo)
        {
            var rootNode = new RootNodeInfo(RootNodeType.Connection) {PasswordString = _key.ConvertToUnsecureString()};
            rootNode.AddChild(connectionInfo);
            var nodeSerializer = new XmlConnectionNodeSerializer26(_cryptographyProvider, _key, new SaveFilter());
            var serializer = new XmlConnectionsSerializer(_cryptographyProvider, nodeSerializer);
            var serializedData = serializer.Serialize(rootNode);
            return XDocument.Parse(serializedData);
        }

        private HarvestConfig<XElement> BuildHarvestConfig(XDocument xdoc)
        {
            var cryptoProvider = new CryptoProviderFactoryFromXml(xdoc.Root).Build();

            return new HarvestConfig<XElement>
            {
                ItemEnumerator = () => xdoc.Descendants("Node"),
                ConnectionGuidSelector = e =>
                {
                    Guid.TryParse(e.Attribute("Id")?.Value, out var connectionId);
                    return connectionId;
                },
                UsernameSelector = e => e.Attribute("Username")?.Value,
                DomainSelector = e => e.Attribute("Domain")?.Value,
                PasswordSelector = e => cryptoProvider.Decrypt(e.Attribute("Password")?.Value, _key).ConvertToSecureString(),
                TitleSelector = e => $"{e.Attribute("Domain")?.Value}{(string.IsNullOrEmpty(e.Attribute("Domain")?.Value) ? "" : "\\")}{e.Attribute("Username")?.Value}"
            };
        }
    }
}