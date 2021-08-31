﻿using System.Drawing;
using mRemoteNG.Credential;
using mRemoteNG.Credential.Repositories;
using mRemoteNG.Tools;
using mRemoteNG.UI.Controls.PageSequence;

namespace mRemoteNG.UI.Forms.CredentialManager.RepoProviders.KeePass
{
    public class KeePassRepositorySelector : ISelectionTarget<ICredentialRepositoryConfig>
    {
        public string Text { get; set; } = "KeePass";
        public Image Image { get; } = Properties.Resources.Key_16x;
        public ICredentialRepositoryConfig DefaultConfig { get; } = new CredentialRepositoryConfig {TypeName = "KeePass"};

        public SequencedControl BuildEditorPage(
            Optional<ICredentialRepositoryConfig> config, 
            ICredentialRepositoryList repositoryList, 
            PageWorkflowController pageWorkflowController)
        {
            // TODO
            return new SequencedControl();
        }
    }
}