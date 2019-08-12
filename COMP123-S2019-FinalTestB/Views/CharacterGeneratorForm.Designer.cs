namespace COMP123_S2019_FinalTestB.Views
{
    partial class CharacterGeneratorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterGeneratorForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.identityPage = new System.Windows.Forms.TabPage();
            this.abilityPage = new System.Windows.Forms.TabPage();
            this.nextButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.inventoryPage = new System.Windows.Forms.TabPage();
            this.characterSheetPage = new System.Windows.Forms.TabPage();
            this.identityTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.generateNameButton = new System.Windows.Forms.Button();
            this.characterNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameDataLabel = new System.Windows.Forms.Label();
            this.lastNameDataLabel = new System.Windows.Forms.Label();
            this.abilitiesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.genrateAbilitiesButton = new System.Windows.Forms.Button();
            this.strengthLabel = new System.Windows.Forms.Label();
            this.intellegenceLabel = new System.Windows.Forms.Label();
            this.wisdomLabel = new System.Windows.Forms.Label();
            this.charismaLabel = new System.Windows.Forms.Label();
            this.dexterityLabel = new System.Windows.Forms.Label();
            this.constitutionLabel = new System.Windows.Forms.Label();
            this.strengthDataLabel = new System.Windows.Forms.Label();
            this.constitutionDataLabel = new System.Windows.Forms.Label();
            this.charismaDataLabel = new System.Windows.Forms.Label();
            this.dexterityDataLabel = new System.Windows.Forms.Label();
            this.intelligenceDataLabel = new System.Windows.Forms.Label();
            this.wisdomDataLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mainToolStrip = new System.Windows.Forms.ToolStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.mainTabControl.SuspendLayout();
            this.identityPage.SuspendLayout();
            this.abilityPage.SuspendLayout();
            this.characterSheetPage.SuspendLayout();
            this.identityTableLayoutPanel.SuspendLayout();
            this.abilitiesTableLayoutPanel.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.mainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.identityPage);
            this.mainTabControl.Controls.Add(this.abilityPage);
            this.mainTabControl.Controls.Add(this.inventoryPage);
            this.mainTabControl.Controls.Add(this.characterSheetPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(784, 474);
            this.mainTabControl.TabIndex = 0;
            // 
            // identityPage
            // 
            this.identityPage.Controls.Add(this.identityTableLayoutPanel);
            this.identityPage.Location = new System.Drawing.Point(4, 33);
            this.identityPage.Name = "identityPage";
            this.identityPage.Padding = new System.Windows.Forms.Padding(3);
            this.identityPage.Size = new System.Drawing.Size(776, 437);
            this.identityPage.TabIndex = 0;
            this.identityPage.Text = "Identity";
            this.identityPage.UseVisualStyleBackColor = true;
            // 
            // abilityPage
            // 
            this.abilityPage.Controls.Add(this.abilitiesTableLayoutPanel);
            this.abilityPage.Location = new System.Drawing.Point(4, 33);
            this.abilityPage.Name = "abilityPage";
            this.abilityPage.Padding = new System.Windows.Forms.Padding(3);
            this.abilityPage.Size = new System.Drawing.Size(776, 437);
            this.abilityPage.TabIndex = 1;
            this.abilityPage.Text = "Abilities";
            this.abilityPage.UseVisualStyleBackColor = true;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(670, 497);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(114, 52);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(0, 497);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(114, 52);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // inventoryPage
            // 
            this.inventoryPage.Location = new System.Drawing.Point(4, 33);
            this.inventoryPage.Name = "inventoryPage";
            this.inventoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.inventoryPage.Size = new System.Drawing.Size(776, 437);
            this.inventoryPage.TabIndex = 2;
            this.inventoryPage.Text = "Inventory";
            this.inventoryPage.UseVisualStyleBackColor = true;
            // 
            // characterSheetPage
            // 
            this.characterSheetPage.Controls.Add(this.mainToolStrip);
            this.characterSheetPage.Controls.Add(this.mainMenuStrip);
            this.characterSheetPage.Location = new System.Drawing.Point(4, 33);
            this.characterSheetPage.Name = "characterSheetPage";
            this.characterSheetPage.Padding = new System.Windows.Forms.Padding(3);
            this.characterSheetPage.Size = new System.Drawing.Size(776, 437);
            this.characterSheetPage.TabIndex = 3;
            this.characterSheetPage.Text = "Character Sheet";
            this.characterSheetPage.UseVisualStyleBackColor = true;
            // 
            // identityTableLayoutPanel
            // 
            this.identityTableLayoutPanel.ColumnCount = 4;
            this.identityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.identityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.identityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identityTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.identityTableLayoutPanel.Controls.Add(this.firstNameLabel, 0, 1);
            this.identityTableLayoutPanel.Controls.Add(this.generateNameButton, 2, 4);
            this.identityTableLayoutPanel.Controls.Add(this.characterNameLabel, 0, 0);
            this.identityTableLayoutPanel.Controls.Add(this.lastNameLabel, 0, 2);
            this.identityTableLayoutPanel.Controls.Add(this.characterNameTextBox, 1, 0);
            this.identityTableLayoutPanel.Controls.Add(this.lastNameDataLabel, 1, 2);
            this.identityTableLayoutPanel.Controls.Add(this.firstNameDataLabel, 1, 1);
            this.identityTableLayoutPanel.Location = new System.Drawing.Point(6, 6);
            this.identityTableLayoutPanel.Name = "identityTableLayoutPanel";
            this.identityTableLayoutPanel.RowCount = 5;
            this.identityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.identityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.identityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.identityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.identityTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.identityTableLayoutPanel.Size = new System.Drawing.Size(762, 343);
            this.identityTableLayoutPanel.TabIndex = 0;
            // 
            // generateNameButton
            // 
            this.generateNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.identityTableLayoutPanel.SetColumnSpan(this.generateNameButton, 2);
            this.generateNameButton.Location = new System.Drawing.Point(383, 275);
            this.generateNameButton.Name = "generateNameButton";
            this.generateNameButton.Size = new System.Drawing.Size(376, 65);
            this.generateNameButton.TabIndex = 1;
            this.generateNameButton.Text = "Generate Name";
            this.generateNameButton.UseVisualStyleBackColor = true;
            // 
            // characterNameLabel
            // 
            this.characterNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.characterNameLabel.Location = new System.Drawing.Point(3, 0);
            this.characterNameLabel.Name = "characterNameLabel";
            this.characterNameLabel.Size = new System.Drawing.Size(222, 68);
            this.characterNameLabel.TabIndex = 2;
            this.characterNameLabel.Text = "Character Name";
            this.characterNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameLabel.Location = new System.Drawing.Point(3, 136);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(222, 68);
            this.lastNameLabel.TabIndex = 3;
            this.lastNameLabel.Text = "Last Name";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameLabel.Location = new System.Drawing.Point(3, 68);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(222, 68);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.identityTableLayoutPanel.SetColumnSpan(this.characterNameTextBox, 3);
            this.characterNameTextBox.Location = new System.Drawing.Point(231, 19);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(528, 29);
            this.characterNameTextBox.TabIndex = 5;
            // 
            // firstNameDataLabel
            // 
            this.firstNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.firstNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.identityTableLayoutPanel.SetColumnSpan(this.firstNameDataLabel, 3);
            this.firstNameDataLabel.Location = new System.Drawing.Point(231, 68);
            this.firstNameDataLabel.Name = "firstNameDataLabel";
            this.firstNameDataLabel.Size = new System.Drawing.Size(528, 68);
            this.firstNameDataLabel.TabIndex = 4;
            this.firstNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lastNameDataLabel
            // 
            this.lastNameDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastNameDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lastNameDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.identityTableLayoutPanel.SetColumnSpan(this.lastNameDataLabel, 3);
            this.lastNameDataLabel.Location = new System.Drawing.Point(231, 136);
            this.lastNameDataLabel.Name = "lastNameDataLabel";
            this.lastNameDataLabel.Size = new System.Drawing.Size(528, 68);
            this.lastNameDataLabel.TabIndex = 4;
            this.lastNameDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // abilitiesTableLayoutPanel
            // 
            this.abilitiesTableLayoutPanel.ColumnCount = 4;
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilitiesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.abilitiesTableLayoutPanel.Controls.Add(this.dexterityDataLabel, 1, 1);
            this.abilitiesTableLayoutPanel.Controls.Add(this.strengthDataLabel, 1, 0);
            this.abilitiesTableLayoutPanel.Controls.Add(this.dexterityLabel, 0, 1);
            this.abilitiesTableLayoutPanel.Controls.Add(this.genrateAbilitiesButton, 2, 7);
            this.abilitiesTableLayoutPanel.Controls.Add(this.strengthLabel, 0, 0);
            this.abilitiesTableLayoutPanel.Controls.Add(this.constitutionLabel, 0, 2);
            this.abilitiesTableLayoutPanel.Controls.Add(this.intellegenceLabel, 0, 3);
            this.abilitiesTableLayoutPanel.Controls.Add(this.wisdomLabel, 0, 4);
            this.abilitiesTableLayoutPanel.Controls.Add(this.charismaLabel, 0, 5);
            this.abilitiesTableLayoutPanel.Controls.Add(this.constitutionDataLabel, 1, 2);
            this.abilitiesTableLayoutPanel.Controls.Add(this.intelligenceDataLabel, 1, 3);
            this.abilitiesTableLayoutPanel.Controls.Add(this.wisdomDataLabel, 1, 4);
            this.abilitiesTableLayoutPanel.Controls.Add(this.charismaDataLabel, 1, 5);
            this.abilitiesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.abilitiesTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.abilitiesTableLayoutPanel.Name = "abilitiesTableLayoutPanel";
            this.abilitiesTableLayoutPanel.RowCount = 8;
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.abilitiesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.abilitiesTableLayoutPanel.Size = new System.Drawing.Size(770, 378);
            this.abilitiesTableLayoutPanel.TabIndex = 0;
            // 
            // genrateAbilitiesButton
            // 
            this.genrateAbilitiesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.abilitiesTableLayoutPanel.SetColumnSpan(this.genrateAbilitiesButton, 2);
            this.genrateAbilitiesButton.Location = new System.Drawing.Point(387, 332);
            this.genrateAbilitiesButton.Name = "genrateAbilitiesButton";
            this.genrateAbilitiesButton.Size = new System.Drawing.Size(380, 43);
            this.genrateAbilitiesButton.TabIndex = 1;
            this.genrateAbilitiesButton.Text = "Generate Abilities";
            this.genrateAbilitiesButton.UseVisualStyleBackColor = true;
            // 
            // strengthLabel
            // 
            this.strengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strengthLabel.Location = new System.Drawing.Point(3, 0);
            this.strengthLabel.Name = "strengthLabel";
            this.strengthLabel.Size = new System.Drawing.Size(186, 47);
            this.strengthLabel.TabIndex = 2;
            this.strengthLabel.Text = "Strength";
            this.strengthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intellegenceLabel
            // 
            this.intellegenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intellegenceLabel.Location = new System.Drawing.Point(3, 141);
            this.intellegenceLabel.Name = "intellegenceLabel";
            this.intellegenceLabel.Size = new System.Drawing.Size(186, 47);
            this.intellegenceLabel.TabIndex = 3;
            this.intellegenceLabel.Text = "Intelligence";
            this.intellegenceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wisdomLabel
            // 
            this.wisdomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wisdomLabel.Location = new System.Drawing.Point(3, 188);
            this.wisdomLabel.Name = "wisdomLabel";
            this.wisdomLabel.Size = new System.Drawing.Size(186, 47);
            this.wisdomLabel.TabIndex = 4;
            this.wisdomLabel.Text = "Wisdom";
            this.wisdomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // charismaLabel
            // 
            this.charismaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charismaLabel.Location = new System.Drawing.Point(3, 235);
            this.charismaLabel.Name = "charismaLabel";
            this.charismaLabel.Size = new System.Drawing.Size(186, 47);
            this.charismaLabel.TabIndex = 5;
            this.charismaLabel.Text = "Charisma";
            this.charismaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dexterityLabel
            // 
            this.dexterityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dexterityLabel.Location = new System.Drawing.Point(3, 47);
            this.dexterityLabel.Name = "dexterityLabel";
            this.dexterityLabel.Size = new System.Drawing.Size(186, 47);
            this.dexterityLabel.TabIndex = 6;
            this.dexterityLabel.Text = "Dexterity";
            this.dexterityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // constitutionLabel
            // 
            this.constitutionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.constitutionLabel.Location = new System.Drawing.Point(3, 94);
            this.constitutionLabel.Name = "constitutionLabel";
            this.constitutionLabel.Size = new System.Drawing.Size(186, 47);
            this.constitutionLabel.TabIndex = 7;
            this.constitutionLabel.Text = "Constitution";
            this.constitutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // strengthDataLabel
            // 
            this.strengthDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strengthDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.strengthDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.strengthDataLabel.Location = new System.Drawing.Point(195, 0);
            this.strengthDataLabel.Name = "strengthDataLabel";
            this.strengthDataLabel.Size = new System.Drawing.Size(186, 47);
            this.strengthDataLabel.TabIndex = 5;
            this.strengthDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // constitutionDataLabel
            // 
            this.constitutionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.constitutionDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.constitutionDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.constitutionDataLabel.Location = new System.Drawing.Point(195, 94);
            this.constitutionDataLabel.Name = "constitutionDataLabel";
            this.constitutionDataLabel.Size = new System.Drawing.Size(186, 47);
            this.constitutionDataLabel.TabIndex = 8;
            this.constitutionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // charismaDataLabel
            // 
            this.charismaDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.charismaDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.charismaDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.charismaDataLabel.Location = new System.Drawing.Point(195, 235);
            this.charismaDataLabel.Name = "charismaDataLabel";
            this.charismaDataLabel.Size = new System.Drawing.Size(186, 47);
            this.charismaDataLabel.TabIndex = 9;
            this.charismaDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dexterityDataLabel
            // 
            this.dexterityDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dexterityDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dexterityDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dexterityDataLabel.Location = new System.Drawing.Point(195, 47);
            this.dexterityDataLabel.Name = "dexterityDataLabel";
            this.dexterityDataLabel.Size = new System.Drawing.Size(186, 47);
            this.dexterityDataLabel.TabIndex = 10;
            this.dexterityDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // intelligenceDataLabel
            // 
            this.intelligenceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.intelligenceDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.intelligenceDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intelligenceDataLabel.Location = new System.Drawing.Point(195, 141);
            this.intelligenceDataLabel.Name = "intelligenceDataLabel";
            this.intelligenceDataLabel.Size = new System.Drawing.Size(186, 47);
            this.intelligenceDataLabel.TabIndex = 11;
            this.intelligenceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // wisdomDataLabel
            // 
            this.wisdomDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wisdomDataLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.wisdomDataLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wisdomDataLabel.Location = new System.Drawing.Point(195, 188);
            this.wisdomDataLabel.Name = "wisdomDataLabel";
            this.wisdomDataLabel.Size = new System.Drawing.Size(186, 47);
            this.wisdomDataLabel.TabIndex = 12;
            this.wisdomDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(3, 3);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(770, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // mainToolStrip
            // 
            this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator6,
            this.helpToolStripButton});
            this.mainToolStrip.Location = new System.Drawing.Point(3, 27);
            this.mainToolStrip.Name = "mainToolStrip";
            this.mainToolStrip.Size = new System.Drawing.Size(770, 25);
            this.mainToolStrip.TabIndex = 1;
            this.mainToolStrip.Text = "toolStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // CharacterGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.mainTabControl);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "CharacterGeneratorForm";
            this.Text = "Character Generator";
            this.mainTabControl.ResumeLayout(false);
            this.identityPage.ResumeLayout(false);
            this.abilityPage.ResumeLayout(false);
            this.characterSheetPage.ResumeLayout(false);
            this.characterSheetPage.PerformLayout();
            this.identityTableLayoutPanel.ResumeLayout(false);
            this.identityTableLayoutPanel.PerformLayout();
            this.abilitiesTableLayoutPanel.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.mainToolStrip.ResumeLayout(false);
            this.mainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage identityPage;
        private System.Windows.Forms.TabPage abilityPage;
        private System.Windows.Forms.TabPage inventoryPage;
        private System.Windows.Forms.TabPage characterSheetPage;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TableLayoutPanel identityTableLayoutPanel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button generateNameButton;
        private System.Windows.Forms.Label characterNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.Label firstNameDataLabel;
        private System.Windows.Forms.Label lastNameDataLabel;
        private System.Windows.Forms.TableLayoutPanel abilitiesTableLayoutPanel;
        private System.Windows.Forms.Label dexterityDataLabel;
        private System.Windows.Forms.Label strengthDataLabel;
        private System.Windows.Forms.Label dexterityLabel;
        private System.Windows.Forms.Button genrateAbilitiesButton;
        private System.Windows.Forms.Label strengthLabel;
        private System.Windows.Forms.Label constitutionLabel;
        private System.Windows.Forms.Label intellegenceLabel;
        private System.Windows.Forms.Label wisdomLabel;
        private System.Windows.Forms.Label charismaLabel;
        private System.Windows.Forms.Label constitutionDataLabel;
        private System.Windows.Forms.Label intelligenceDataLabel;
        private System.Windows.Forms.Label wisdomDataLabel;
        private System.Windows.Forms.Label charismaDataLabel;
        private System.Windows.Forms.ToolStrip mainToolStrip;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}
