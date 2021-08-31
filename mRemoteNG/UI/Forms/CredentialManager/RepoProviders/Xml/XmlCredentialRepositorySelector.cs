﻿using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using mRemoteNG.Credential;
using mRemoteNG.Credential.Repositories;
using mRemoteNG.Tools;
using mRemoteNG.UI.Controls.PageSequence;

namespace mRemoteNG.UI.Forms.CredentialManager.RepoProviders.Xml
{
    public class XmlCredentialRepositorySelector : ISelectionTarget<ICredentialRepositoryConfig>
    {
        private readonly CredentialService _credentialService;

        public string Text { get; set; } = "XML";
        public Image Image { get; } = Properties.Resources.Key_16x;
        public ICredentialRepositoryConfig DefaultConfig { get; } = new CredentialRepositoryConfig {TypeName = "Xml"};

        public XmlCredentialRepositorySelector(CredentialService credentialService)
        {
            _credentialService = credentialService.ThrowIfNull(nameof(credentialService));
        }

        public SequencedControl BuildEditorPage(
            Optional<ICredentialRepositoryConfig> config,
            ICredentialRepositoryList repositoryList, 
            PageWorkflowController pageWorkflowController)
        {
            var repositoryFactory = _credentialService.GetRepositoryFactoryForConfig(DefaultConfig);

            if (!repositoryFactory.Any())
                throw new CredentialRepositoryTypeNotSupportedException(DefaultConfig.TypeName);

            return new XmlCredentialRepositoryEditorPage(config.FirstOrDefault() ?? DefaultConfig, 
                repositoryList, 
                repositoryFactory.First(), 
                pageWorkflowController)
            {
                Dock = DockStyle.Fill
            };
        }
    }
}