namespace WindowsFormsApp1 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose ();
            }
            base.Dispose (disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent () {
            this.components = new System.ComponentModel.Container();
            this.grid = new Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(this.components);
            this.exportPath = new System.Windows.Forms.FolderBrowserDialog();
            this.export = new System.Windows.Forms.Button();
            this.saveDialog = new System.Windows.Forms.SaveFileDialog();
            this.loadButton = new System.Windows.Forms.Button();
            this.loadDialog = new System.Windows.Forms.OpenFileDialog();
            this.brick1 = new System.Windows.Forms.ComboBox();
            this.brick6 = new System.Windows.Forms.ComboBox();
            this.brick5 = new System.Windows.Forms.ComboBox();
            this.brick4 = new System.Windows.Forms.ComboBox();
            this.brick3 = new System.Windows.Forms.ComboBox();
            this.brick2 = new System.Windows.Forms.ComboBox();
            this.brick8 = new System.Windows.Forms.ComboBox();
            this.brick9 = new System.Windows.Forms.ComboBox();
            this.brick10 = new System.Windows.Forms.ComboBox();
            this.brick11 = new System.Windows.Forms.ComboBox();
            this.brick12 = new System.Windows.Forms.ComboBox();
            this.brick7 = new System.Windows.Forms.ComboBox();
            this.brick20 = new System.Windows.Forms.ComboBox();
            this.brick21 = new System.Windows.Forms.ComboBox();
            this.brick22 = new System.Windows.Forms.ComboBox();
            this.brick23 = new System.Windows.Forms.ComboBox();
            this.brick24 = new System.Windows.Forms.ComboBox();
            this.brick19 = new System.Windows.Forms.ComboBox();
            this.brick14 = new System.Windows.Forms.ComboBox();
            this.brick15 = new System.Windows.Forms.ComboBox();
            this.brick16 = new System.Windows.Forms.ComboBox();
            this.brick17 = new System.Windows.Forms.ComboBox();
            this.brick18 = new System.Windows.Forms.ComboBox();
            this.brick13 = new System.Windows.Forms.ComboBox();
            this.brick44 = new System.Windows.Forms.ComboBox();
            this.brick45 = new System.Windows.Forms.ComboBox();
            this.brick46 = new System.Windows.Forms.ComboBox();
            this.brick47 = new System.Windows.Forms.ComboBox();
            this.brick48 = new System.Windows.Forms.ComboBox();
            this.brick43 = new System.Windows.Forms.ComboBox();
            this.brick38 = new System.Windows.Forms.ComboBox();
            this.brick39 = new System.Windows.Forms.ComboBox();
            this.brick40 = new System.Windows.Forms.ComboBox();
            this.brick41 = new System.Windows.Forms.ComboBox();
            this.brick42 = new System.Windows.Forms.ComboBox();
            this.brick37 = new System.Windows.Forms.ComboBox();
            this.brick32 = new System.Windows.Forms.ComboBox();
            this.brick33 = new System.Windows.Forms.ComboBox();
            this.brick34 = new System.Windows.Forms.ComboBox();
            this.brick35 = new System.Windows.Forms.ComboBox();
            this.brick36 = new System.Windows.Forms.ComboBox();
            this.brick31 = new System.Windows.Forms.ComboBox();
            this.brick26 = new System.Windows.Forms.ComboBox();
            this.brick27 = new System.Windows.Forms.ComboBox();
            this.brick28 = new System.Windows.Forms.ComboBox();
            this.brick29 = new System.Windows.Forms.ComboBox();
            this.brick30 = new System.Windows.Forms.ComboBox();
            this.brick25 = new System.Windows.Forms.ComboBox();
            this.brick56 = new System.Windows.Forms.ComboBox();
            this.brick57 = new System.Windows.Forms.ComboBox();
            this.brick58 = new System.Windows.Forms.ComboBox();
            this.brick59 = new System.Windows.Forms.ComboBox();
            this.brick60 = new System.Windows.Forms.ComboBox();
            this.brick55 = new System.Windows.Forms.ComboBox();
            this.brick50 = new System.Windows.Forms.ComboBox();
            this.brick51 = new System.Windows.Forms.ComboBox();
            this.brick52 = new System.Windows.Forms.ComboBox();
            this.brick53 = new System.Windows.Forms.ComboBox();
            this.brick54 = new System.Windows.Forms.ComboBox();
            this.brick49 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(1084, 570);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(187, 62);
            this.export.TabIndex = 12;
            this.export.Text = "Save";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.Export_Click);
            // 
            // saveDialog
            // 
            this.saveDialog.Filter = "C file (*.c)|*.c";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(20, 570);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(187, 62);
            this.loadButton.TabIndex = 13;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.lodeButton_Click);
            // 
            // loadDialog
            // 
            this.loadDialog.FileName = "openFileDialog1";
            // 
            // brick1
            // 
            this.brick1.FormattingEnabled = true;
            this.brick1.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick1.Location = new System.Drawing.Point(20, 13);
            this.brick1.Name = "brick1";
            this.brick1.Size = new System.Drawing.Size(204, 39);
            this.brick1.TabIndex = 14;
            // 
            // brick6
            // 
            this.brick6.FormattingEnabled = true;
            this.brick6.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick6.Location = new System.Drawing.Point(1067, 13);
            this.brick6.Name = "brick6";
            this.brick6.Size = new System.Drawing.Size(204, 39);
            this.brick6.TabIndex = 15;
            // 
            // brick5
            // 
            this.brick5.FormattingEnabled = true;
            this.brick5.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick5.Location = new System.Drawing.Point(857, 13);
            this.brick5.Name = "brick5";
            this.brick5.Size = new System.Drawing.Size(204, 39);
            this.brick5.TabIndex = 16;
            // 
            // brick4
            // 
            this.brick4.FormattingEnabled = true;
            this.brick4.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick4.Location = new System.Drawing.Point(647, 13);
            this.brick4.Name = "brick4";
            this.brick4.Size = new System.Drawing.Size(204, 39);
            this.brick4.TabIndex = 17;
            // 
            // brick3
            // 
            this.brick3.FormattingEnabled = true;
            this.brick3.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick3.Location = new System.Drawing.Point(437, 13);
            this.brick3.Name = "brick3";
            this.brick3.Size = new System.Drawing.Size(204, 39);
            this.brick3.TabIndex = 18;
            // 
            // brick2
            // 
            this.brick2.FormattingEnabled = true;
            this.brick2.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick2.Location = new System.Drawing.Point(227, 13);
            this.brick2.Name = "brick2";
            this.brick2.Size = new System.Drawing.Size(204, 39);
            this.brick2.TabIndex = 19;
            // 
            // brick8
            // 
            this.brick8.FormattingEnabled = true;
            this.brick8.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick8.Location = new System.Drawing.Point(227, 58);
            this.brick8.Name = "brick8";
            this.brick8.Size = new System.Drawing.Size(204, 39);
            this.brick8.TabIndex = 43;
            // 
            // brick9
            // 
            this.brick9.FormattingEnabled = true;
            this.brick9.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick9.Location = new System.Drawing.Point(437, 58);
            this.brick9.Name = "brick9";
            this.brick9.Size = new System.Drawing.Size(204, 39);
            this.brick9.TabIndex = 42;
            // 
            // brick10
            // 
            this.brick10.FormattingEnabled = true;
            this.brick10.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick10.Location = new System.Drawing.Point(647, 58);
            this.brick10.Name = "brick10";
            this.brick10.Size = new System.Drawing.Size(204, 39);
            this.brick10.TabIndex = 41;
            // 
            // brick11
            // 
            this.brick11.FormattingEnabled = true;
            this.brick11.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick11.Location = new System.Drawing.Point(857, 58);
            this.brick11.Name = "brick11";
            this.brick11.Size = new System.Drawing.Size(204, 39);
            this.brick11.TabIndex = 40;
            // 
            // brick12
            // 
            this.brick12.FormattingEnabled = true;
            this.brick12.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick12.Location = new System.Drawing.Point(1067, 58);
            this.brick12.Name = "brick12";
            this.brick12.Size = new System.Drawing.Size(204, 39);
            this.brick12.TabIndex = 39;
            // 
            // brick7
            // 
            this.brick7.FormattingEnabled = true;
            this.brick7.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick7.Location = new System.Drawing.Point(17, 58);
            this.brick7.Name = "brick7";
            this.brick7.Size = new System.Drawing.Size(204, 39);
            this.brick7.TabIndex = 38;
            // 
            // brick20
            // 
            this.brick20.FormattingEnabled = true;
            this.brick20.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick20.Location = new System.Drawing.Point(227, 148);
            this.brick20.Name = "brick20";
            this.brick20.Size = new System.Drawing.Size(204, 39);
            this.brick20.TabIndex = 55;
            // 
            // brick21
            // 
            this.brick21.FormattingEnabled = true;
            this.brick21.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick21.Location = new System.Drawing.Point(437, 148);
            this.brick21.Name = "brick21";
            this.brick21.Size = new System.Drawing.Size(204, 39);
            this.brick21.TabIndex = 54;
            // 
            // brick22
            // 
            this.brick22.FormattingEnabled = true;
            this.brick22.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick22.Location = new System.Drawing.Point(647, 148);
            this.brick22.Name = "brick22";
            this.brick22.Size = new System.Drawing.Size(204, 39);
            this.brick22.TabIndex = 53;
            // 
            // brick23
            // 
            this.brick23.FormattingEnabled = true;
            this.brick23.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick23.Location = new System.Drawing.Point(857, 148);
            this.brick23.Name = "brick23";
            this.brick23.Size = new System.Drawing.Size(204, 39);
            this.brick23.TabIndex = 52;
            // 
            // brick24
            // 
            this.brick24.FormattingEnabled = true;
            this.brick24.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick24.Location = new System.Drawing.Point(1067, 148);
            this.brick24.Name = "brick24";
            this.brick24.Size = new System.Drawing.Size(204, 39);
            this.brick24.TabIndex = 51;
            // 
            // brick19
            // 
            this.brick19.FormattingEnabled = true;
            this.brick19.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick19.Location = new System.Drawing.Point(17, 148);
            this.brick19.Name = "brick19";
            this.brick19.Size = new System.Drawing.Size(204, 39);
            this.brick19.TabIndex = 50;
            // 
            // brick14
            // 
            this.brick14.FormattingEnabled = true;
            this.brick14.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick14.Location = new System.Drawing.Point(227, 103);
            this.brick14.Name = "brick14";
            this.brick14.Size = new System.Drawing.Size(204, 39);
            this.brick14.TabIndex = 49;
            // 
            // brick15
            // 
            this.brick15.FormattingEnabled = true;
            this.brick15.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick15.Location = new System.Drawing.Point(437, 103);
            this.brick15.Name = "brick15";
            this.brick15.Size = new System.Drawing.Size(204, 39);
            this.brick15.TabIndex = 48;
            // 
            // brick16
            // 
            this.brick16.FormattingEnabled = true;
            this.brick16.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick16.Location = new System.Drawing.Point(647, 103);
            this.brick16.Name = "brick16";
            this.brick16.Size = new System.Drawing.Size(204, 39);
            this.brick16.TabIndex = 47;
            // 
            // brick17
            // 
            this.brick17.FormattingEnabled = true;
            this.brick17.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick17.Location = new System.Drawing.Point(857, 103);
            this.brick17.Name = "brick17";
            this.brick17.Size = new System.Drawing.Size(204, 39);
            this.brick17.TabIndex = 46;
            // 
            // brick18
            // 
            this.brick18.FormattingEnabled = true;
            this.brick18.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick18.Location = new System.Drawing.Point(1067, 103);
            this.brick18.Name = "brick18";
            this.brick18.Size = new System.Drawing.Size(204, 39);
            this.brick18.TabIndex = 45;
            // 
            // brick13
            // 
            this.brick13.FormattingEnabled = true;
            this.brick13.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick13.Location = new System.Drawing.Point(17, 103);
            this.brick13.Name = "brick13";
            this.brick13.Size = new System.Drawing.Size(204, 39);
            this.brick13.TabIndex = 44;
            // 
            // brick44
            // 
            this.brick44.FormattingEnabled = true;
            this.brick44.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick44.Location = new System.Drawing.Point(227, 328);
            this.brick44.Name = "brick44";
            this.brick44.Size = new System.Drawing.Size(204, 39);
            this.brick44.TabIndex = 79;
            // 
            // brick45
            // 
            this.brick45.FormattingEnabled = true;
            this.brick45.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick45.Location = new System.Drawing.Point(437, 328);
            this.brick45.Name = "brick45";
            this.brick45.Size = new System.Drawing.Size(204, 39);
            this.brick45.TabIndex = 78;
            // 
            // brick46
            // 
            this.brick46.FormattingEnabled = true;
            this.brick46.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick46.Location = new System.Drawing.Point(647, 328);
            this.brick46.Name = "brick46";
            this.brick46.Size = new System.Drawing.Size(204, 39);
            this.brick46.TabIndex = 77;
            // 
            // brick47
            // 
            this.brick47.FormattingEnabled = true;
            this.brick47.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick47.Location = new System.Drawing.Point(857, 328);
            this.brick47.Name = "brick47";
            this.brick47.Size = new System.Drawing.Size(204, 39);
            this.brick47.TabIndex = 76;
            // 
            // brick48
            // 
            this.brick48.FormattingEnabled = true;
            this.brick48.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick48.Location = new System.Drawing.Point(1067, 328);
            this.brick48.Name = "brick48";
            this.brick48.Size = new System.Drawing.Size(204, 39);
            this.brick48.TabIndex = 75;
            // 
            // brick43
            // 
            this.brick43.FormattingEnabled = true;
            this.brick43.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick43.Location = new System.Drawing.Point(17, 328);
            this.brick43.Name = "brick43";
            this.brick43.Size = new System.Drawing.Size(204, 39);
            this.brick43.TabIndex = 74;
            // 
            // brick38
            // 
            this.brick38.FormattingEnabled = true;
            this.brick38.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick38.Location = new System.Drawing.Point(227, 283);
            this.brick38.Name = "brick38";
            this.brick38.Size = new System.Drawing.Size(204, 39);
            this.brick38.TabIndex = 73;
            // 
            // brick39
            // 
            this.brick39.FormattingEnabled = true;
            this.brick39.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick39.Location = new System.Drawing.Point(437, 283);
            this.brick39.Name = "brick39";
            this.brick39.Size = new System.Drawing.Size(204, 39);
            this.brick39.TabIndex = 72;
            // 
            // brick40
            // 
            this.brick40.FormattingEnabled = true;
            this.brick40.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick40.Location = new System.Drawing.Point(647, 283);
            this.brick40.Name = "brick40";
            this.brick40.Size = new System.Drawing.Size(204, 39);
            this.brick40.TabIndex = 71;
            // 
            // brick41
            // 
            this.brick41.FormattingEnabled = true;
            this.brick41.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick41.Location = new System.Drawing.Point(857, 283);
            this.brick41.Name = "brick41";
            this.brick41.Size = new System.Drawing.Size(204, 39);
            this.brick41.TabIndex = 70;
            // 
            // brick42
            // 
            this.brick42.FormattingEnabled = true;
            this.brick42.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick42.Location = new System.Drawing.Point(1067, 283);
            this.brick42.Name = "brick42";
            this.brick42.Size = new System.Drawing.Size(204, 39);
            this.brick42.TabIndex = 69;
            // 
            // brick37
            // 
            this.brick37.FormattingEnabled = true;
            this.brick37.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick37.Location = new System.Drawing.Point(17, 283);
            this.brick37.Name = "brick37";
            this.brick37.Size = new System.Drawing.Size(204, 39);
            this.brick37.TabIndex = 68;
            // 
            // brick32
            // 
            this.brick32.FormattingEnabled = true;
            this.brick32.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick32.Location = new System.Drawing.Point(227, 238);
            this.brick32.Name = "brick32";
            this.brick32.Size = new System.Drawing.Size(204, 39);
            this.brick32.TabIndex = 67;
            // 
            // brick33
            // 
            this.brick33.FormattingEnabled = true;
            this.brick33.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick33.Location = new System.Drawing.Point(437, 238);
            this.brick33.Name = "brick33";
            this.brick33.Size = new System.Drawing.Size(204, 39);
            this.brick33.TabIndex = 66;
            // 
            // brick34
            // 
            this.brick34.FormattingEnabled = true;
            this.brick34.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick34.Location = new System.Drawing.Point(647, 238);
            this.brick34.Name = "brick34";
            this.brick34.Size = new System.Drawing.Size(204, 39);
            this.brick34.TabIndex = 65;
            // 
            // brick35
            // 
            this.brick35.FormattingEnabled = true;
            this.brick35.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick35.Location = new System.Drawing.Point(857, 238);
            this.brick35.Name = "brick35";
            this.brick35.Size = new System.Drawing.Size(204, 39);
            this.brick35.TabIndex = 64;
            // 
            // brick36
            // 
            this.brick36.FormattingEnabled = true;
            this.brick36.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick36.Location = new System.Drawing.Point(1067, 238);
            this.brick36.Name = "brick36";
            this.brick36.Size = new System.Drawing.Size(204, 39);
            this.brick36.TabIndex = 63;
            // 
            // brick31
            // 
            this.brick31.FormattingEnabled = true;
            this.brick31.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick31.Location = new System.Drawing.Point(17, 238);
            this.brick31.Name = "brick31";
            this.brick31.Size = new System.Drawing.Size(204, 39);
            this.brick31.TabIndex = 62;
            // 
            // brick26
            // 
            this.brick26.FormattingEnabled = true;
            this.brick26.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick26.Location = new System.Drawing.Point(227, 193);
            this.brick26.Name = "brick26";
            this.brick26.Size = new System.Drawing.Size(204, 39);
            this.brick26.TabIndex = 61;
            // 
            // brick27
            // 
            this.brick27.FormattingEnabled = true;
            this.brick27.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick27.Location = new System.Drawing.Point(437, 193);
            this.brick27.Name = "brick27";
            this.brick27.Size = new System.Drawing.Size(204, 39);
            this.brick27.TabIndex = 60;
            // 
            // brick28
            // 
            this.brick28.FormattingEnabled = true;
            this.brick28.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick28.Location = new System.Drawing.Point(647, 193);
            this.brick28.Name = "brick28";
            this.brick28.Size = new System.Drawing.Size(204, 39);
            this.brick28.TabIndex = 59;
            // 
            // brick29
            // 
            this.brick29.FormattingEnabled = true;
            this.brick29.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick29.Location = new System.Drawing.Point(857, 193);
            this.brick29.Name = "brick29";
            this.brick29.Size = new System.Drawing.Size(204, 39);
            this.brick29.TabIndex = 58;
            // 
            // brick30
            // 
            this.brick30.FormattingEnabled = true;
            this.brick30.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick30.Location = new System.Drawing.Point(1067, 193);
            this.brick30.Name = "brick30";
            this.brick30.Size = new System.Drawing.Size(204, 39);
            this.brick30.TabIndex = 57;
            // 
            // brick25
            // 
            this.brick25.FormattingEnabled = true;
            this.brick25.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick25.Location = new System.Drawing.Point(17, 193);
            this.brick25.Name = "brick25";
            this.brick25.Size = new System.Drawing.Size(204, 39);
            this.brick25.TabIndex = 56;
            // 
            // brick56
            // 
            this.brick56.FormattingEnabled = true;
            this.brick56.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick56.Location = new System.Drawing.Point(227, 418);
            this.brick56.Name = "brick56";
            this.brick56.Size = new System.Drawing.Size(204, 39);
            this.brick56.TabIndex = 91;
            // 
            // brick57
            // 
            this.brick57.FormattingEnabled = true;
            this.brick57.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick57.Location = new System.Drawing.Point(437, 418);
            this.brick57.Name = "brick57";
            this.brick57.Size = new System.Drawing.Size(204, 39);
            this.brick57.TabIndex = 90;
            // 
            // brick58
            // 
            this.brick58.FormattingEnabled = true;
            this.brick58.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick58.Location = new System.Drawing.Point(647, 418);
            this.brick58.Name = "brick58";
            this.brick58.Size = new System.Drawing.Size(204, 39);
            this.brick58.TabIndex = 89;
            // 
            // brick59
            // 
            this.brick59.FormattingEnabled = true;
            this.brick59.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick59.Location = new System.Drawing.Point(857, 418);
            this.brick59.Name = "brick59";
            this.brick59.Size = new System.Drawing.Size(204, 39);
            this.brick59.TabIndex = 88;
            // 
            // brick60
            // 
            this.brick60.FormattingEnabled = true;
            this.brick60.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick60.Location = new System.Drawing.Point(1067, 418);
            this.brick60.Name = "brick60";
            this.brick60.Size = new System.Drawing.Size(204, 39);
            this.brick60.TabIndex = 87;
            // 
            // brick55
            // 
            this.brick55.FormattingEnabled = true;
            this.brick55.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick55.Location = new System.Drawing.Point(17, 418);
            this.brick55.Name = "brick55";
            this.brick55.Size = new System.Drawing.Size(204, 39);
            this.brick55.TabIndex = 86;
            // 
            // brick50
            // 
            this.brick50.FormattingEnabled = true;
            this.brick50.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick50.Location = new System.Drawing.Point(227, 373);
            this.brick50.Name = "brick50";
            this.brick50.Size = new System.Drawing.Size(204, 39);
            this.brick50.TabIndex = 85;
            // 
            // brick51
            // 
            this.brick51.FormattingEnabled = true;
            this.brick51.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick51.Location = new System.Drawing.Point(437, 373);
            this.brick51.Name = "brick51";
            this.brick51.Size = new System.Drawing.Size(204, 39);
            this.brick51.TabIndex = 84;
            // 
            // brick52
            // 
            this.brick52.FormattingEnabled = true;
            this.brick52.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick52.Location = new System.Drawing.Point(647, 373);
            this.brick52.Name = "brick52";
            this.brick52.Size = new System.Drawing.Size(204, 39);
            this.brick52.TabIndex = 83;
            // 
            // brick53
            // 
            this.brick53.FormattingEnabled = true;
            this.brick53.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick53.Location = new System.Drawing.Point(857, 373);
            this.brick53.Name = "brick53";
            this.brick53.Size = new System.Drawing.Size(204, 39);
            this.brick53.TabIndex = 82;
            // 
            // brick54
            // 
            this.brick54.FormattingEnabled = true;
            this.brick54.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick54.Location = new System.Drawing.Point(1067, 373);
            this.brick54.Name = "brick54";
            this.brick54.Size = new System.Drawing.Size(204, 39);
            this.brick54.TabIndex = 81;
            // 
            // brick49
            // 
            this.brick49.FormattingEnabled = true;
            this.brick49.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.brick49.Location = new System.Drawing.Point(17, 373);
            this.brick49.Name = "brick49";
            this.brick49.Size = new System.Drawing.Size(204, 39);
            this.brick49.TabIndex = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 692);
            this.Controls.Add(this.brick56);
            this.Controls.Add(this.brick57);
            this.Controls.Add(this.brick58);
            this.Controls.Add(this.brick59);
            this.Controls.Add(this.brick60);
            this.Controls.Add(this.brick55);
            this.Controls.Add(this.brick50);
            this.Controls.Add(this.brick51);
            this.Controls.Add(this.brick52);
            this.Controls.Add(this.brick53);
            this.Controls.Add(this.brick54);
            this.Controls.Add(this.brick49);
            this.Controls.Add(this.brick44);
            this.Controls.Add(this.brick45);
            this.Controls.Add(this.brick46);
            this.Controls.Add(this.brick47);
            this.Controls.Add(this.brick48);
            this.Controls.Add(this.brick43);
            this.Controls.Add(this.brick38);
            this.Controls.Add(this.brick39);
            this.Controls.Add(this.brick40);
            this.Controls.Add(this.brick41);
            this.Controls.Add(this.brick42);
            this.Controls.Add(this.brick37);
            this.Controls.Add(this.brick32);
            this.Controls.Add(this.brick33);
            this.Controls.Add(this.brick34);
            this.Controls.Add(this.brick35);
            this.Controls.Add(this.brick36);
            this.Controls.Add(this.brick31);
            this.Controls.Add(this.brick26);
            this.Controls.Add(this.brick27);
            this.Controls.Add(this.brick28);
            this.Controls.Add(this.brick29);
            this.Controls.Add(this.brick30);
            this.Controls.Add(this.brick25);
            this.Controls.Add(this.brick20);
            this.Controls.Add(this.brick21);
            this.Controls.Add(this.brick22);
            this.Controls.Add(this.brick23);
            this.Controls.Add(this.brick24);
            this.Controls.Add(this.brick19);
            this.Controls.Add(this.brick14);
            this.Controls.Add(this.brick15);
            this.Controls.Add(this.brick16);
            this.Controls.Add(this.brick17);
            this.Controls.Add(this.brick18);
            this.Controls.Add(this.brick13);
            this.Controls.Add(this.brick8);
            this.Controls.Add(this.brick9);
            this.Controls.Add(this.brick10);
            this.Controls.Add(this.brick11);
            this.Controls.Add(this.brick12);
            this.Controls.Add(this.brick7);
            this.Controls.Add(this.brick2);
            this.Controls.Add(this.brick3);
            this.Controls.Add(this.brick4);
            this.Controls.Add(this.brick5);
            this.Controls.Add(this.brick6);
            this.Controls.Add(this.brick1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.export);
            this.Name = "Form1";
            this.Text = "Brick Grid Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray grid;
        private System.Windows.Forms.FolderBrowserDialog exportPath;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.SaveFileDialog saveDialog;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.OpenFileDialog loadDialog;
        private System.Windows.Forms.ComboBox brick1;
        private System.Windows.Forms.ComboBox brick6;
        private System.Windows.Forms.ComboBox brick5;
        private System.Windows.Forms.ComboBox brick4;
        private System.Windows.Forms.ComboBox brick3;
        private System.Windows.Forms.ComboBox brick2;
        private System.Windows.Forms.ComboBox brick8;
        private System.Windows.Forms.ComboBox brick9;
        private System.Windows.Forms.ComboBox brick10;
        private System.Windows.Forms.ComboBox brick11;
        private System.Windows.Forms.ComboBox brick12;
        private System.Windows.Forms.ComboBox brick7;
        private System.Windows.Forms.ComboBox brick20;
        private System.Windows.Forms.ComboBox brick21;
        private System.Windows.Forms.ComboBox brick22;
        private System.Windows.Forms.ComboBox brick23;
        private System.Windows.Forms.ComboBox brick24;
        private System.Windows.Forms.ComboBox brick19;
        private System.Windows.Forms.ComboBox brick14;
        private System.Windows.Forms.ComboBox brick16;
        private System.Windows.Forms.ComboBox brick17;
        private System.Windows.Forms.ComboBox brick18;
        private System.Windows.Forms.ComboBox brick13;
        private System.Windows.Forms.ComboBox brick44;
        private System.Windows.Forms.ComboBox brick45;
        private System.Windows.Forms.ComboBox brick46;
        private System.Windows.Forms.ComboBox brick47;
        private System.Windows.Forms.ComboBox brick48;
        private System.Windows.Forms.ComboBox brick43;
        private System.Windows.Forms.ComboBox brick38;
        private System.Windows.Forms.ComboBox brick39;
        private System.Windows.Forms.ComboBox brick40;
        private System.Windows.Forms.ComboBox brick41;
        private System.Windows.Forms.ComboBox brick42;
        private System.Windows.Forms.ComboBox brick37;
        private System.Windows.Forms.ComboBox brick32;
        private System.Windows.Forms.ComboBox brick33;
        private System.Windows.Forms.ComboBox brick34;
        private System.Windows.Forms.ComboBox brick35;
        private System.Windows.Forms.ComboBox brick36;
        private System.Windows.Forms.ComboBox brick31;
        private System.Windows.Forms.ComboBox brick26;
        private System.Windows.Forms.ComboBox brick27;
        private System.Windows.Forms.ComboBox brick28;
        private System.Windows.Forms.ComboBox brick29;
        private System.Windows.Forms.ComboBox brick30;
        private System.Windows.Forms.ComboBox brick25;
        private System.Windows.Forms.ComboBox brick56;
        private System.Windows.Forms.ComboBox brick57;
        private System.Windows.Forms.ComboBox brick58;
        private System.Windows.Forms.ComboBox brick59;
        private System.Windows.Forms.ComboBox brick60;
        private System.Windows.Forms.ComboBox brick55;
        private System.Windows.Forms.ComboBox brick50;
        private System.Windows.Forms.ComboBox brick51;
        private System.Windows.Forms.ComboBox brick52;
        private System.Windows.Forms.ComboBox brick53;
        private System.Windows.Forms.ComboBox brick54;
        private System.Windows.Forms.ComboBox brick49;
        private System.Windows.Forms.ComboBox brick15;
    }
}

