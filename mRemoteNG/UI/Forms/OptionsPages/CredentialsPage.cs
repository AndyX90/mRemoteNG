﻿using System;
using mRemoteNG.Properties;
using mRemoteNG.Credential;

namespace mRemoteNG.UI.Forms.OptionsPages
{
    public sealed partial class CredentialsPage : OptionsPage
	{
	    private readonly CredentialService _credentialService;

        public CredentialsPage(CredentialService credentialService)
        {
            _credentialService = credentialService;
            InitializeComponent();
            ApplyTheme();
            PageIcon = Resources.ImageConverter.GetImageAsIcon(Properties.Resources.Key_16x);
        }

        public override string PageName
        {
            get => Language.Credentials;
            set { }
        }

        public override void ApplyLanguage()
        {
            base.ApplyLanguage();

            //TODO: RESX
            //checkBoxUnlockOnStartup.Text = Language.PromptUnlockCredReposOnStartup;
            //lblDefaultCredentials.Text = Language.strEmptyUsernamePasswordDomainFields;
            //radCredentialsNoInfo.Text = Language.strNoInformation;
            //radCredentialsWindows.Text = Language.strMyCurrentWindowsCreds;
            //radCredentialsCustom.Text = Language.strTheFollowing;
        }

        public override void LoadSettings()
        {
            checkBoxUnlockOnStartup.Checked = Settings.Default.PromptUnlockCredReposOnStartup;

            // ReSharper disable once SwitchStatementMissingSomeCases
            switch (Settings.Default.EmptyCredentials)
            {
                case "noinfo":
                    radCredentialsNoInfo.Checked = true;
                    break;
                case "windows":
                    radCredentialsWindows.Checked = true;
                    break;
                case "custom":
                    radCredentialsCustom.Checked = true;
                    break;
            }

            credentialRecordComboBox1.CredentialRecords = _credentialService.GetCredentialRecords();
            credentialRecordComboBox1.SelectedItem = _credentialService.GetCredentialRecord(Settings.Default.DefaultCredentialRecord);
        }

        public override void SaveSettings()
        {
            Settings.Default.PromptUnlockCredReposOnStartup = checkBoxUnlockOnStartup.Checked;

            if (radCredentialsNoInfo.Checked)
            {
                Settings.Default.EmptyCredentials = "noinfo";
            }
            else if (radCredentialsWindows.Checked)
            {
                Settings.Default.EmptyCredentials = "windows";
            }
            else if (radCredentialsCustom.Checked)
            {
                Settings.Default.EmptyCredentials = "custom";
            }

            Settings.Default.DefaultCredentialRecord = (credentialRecordComboBox1.SelectedItem as ICredentialRecord)?.Id ?? Guid.Empty;
        }
    }
}