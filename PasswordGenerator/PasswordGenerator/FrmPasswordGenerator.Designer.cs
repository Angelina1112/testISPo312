namespace PasswordGenerator
{
    partial class FrmPasswordGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            GroupBoxGenerationParams = new GroupBox();
            LabelPasswordLengthValue = new Label();
            LabelPasswordLength = new Label();
            TrackBarPasswordLength = new TrackBar();
            CheckBoxUseUppercaseLetters = new CheckBox();
            CheckBoxUseLowercaseLetters = new CheckBox();
            CheckBoxUseDigits = new CheckBox();
            CheckBoxUseSpecialSymbols = new CheckBox();
            ButtonGeneratePassword = new Button();
            ButtonExit = new Button();
            ButtonClearPassword = new Button();
            LabelGeneratedPassword = new Label();
            LabelWarningMessageTitle = new Label();
            LabelPasswordCopiedToClipboard = new Label();
            LabelWarningMessage = new Label();
            TextBoxGeneratedPassword = new TextBox();
            TimerShowLabelCopiedToClipboard = new System.Windows.Forms.Timer(components);
            ImageListDefault = new ImageList(components);
            ToolTipForControl = new ToolTip(components);
            GroupBoxGenerationParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBarPasswordLength).BeginInit();
            SuspendLayout();
            // 
            // GroupBoxGenerationParams
            // 
            GroupBoxGenerationParams.Controls.Add(LabelPasswordLengthValue);
            GroupBoxGenerationParams.Controls.Add(LabelPasswordLength);
            GroupBoxGenerationParams.Controls.Add(TrackBarPasswordLength);
            GroupBoxGenerationParams.Controls.Add(CheckBoxUseUppercaseLetters);
            GroupBoxGenerationParams.Controls.Add(CheckBoxUseLowercaseLetters);
            GroupBoxGenerationParams.Controls.Add(CheckBoxUseDigits);
            GroupBoxGenerationParams.Controls.Add(CheckBoxUseSpecialSymbols);
            GroupBoxGenerationParams.Location = new Point(12, 12);
            GroupBoxGenerationParams.Name = "GroupBoxGenerationParams";
            GroupBoxGenerationParams.Size = new Size(715, 171);
            GroupBoxGenerationParams.TabIndex = 0;
            GroupBoxGenerationParams.TabStop = false;
            GroupBoxGenerationParams.Text = "Параметры генерации пароля:";
            // 
            // LabelPasswordLengthValue
            // 
            LabelPasswordLengthValue.AutoSize = true;
            LabelPasswordLengthValue.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            LabelPasswordLengthValue.Location = new Point(201, 120);
            LabelPasswordLengthValue.Name = "LabelPasswordLengthValue";
            LabelPasswordLengthValue.Size = new Size(26, 17);
            LabelPasswordLengthValue.TabIndex = 6;
            LabelPasswordLengthValue.Text = "##";
            // 
            // LabelPasswordLength
            // 
            LabelPasswordLength.AutoSize = true;
            LabelPasswordLength.Location = new Point(6, 118);
            LabelPasswordLength.Name = "LabelPasswordLength";
            LabelPasswordLength.Size = new Size(194, 20);
            LabelPasswordLength.TabIndex = 5;
            LabelPasswordLength.Text = "Длина пароля (символов):";
            // 
            // TrackBarPasswordLength
            // 
            TrackBarPasswordLength.Location = new Point(292, 109);
            TrackBarPasswordLength.Maximum = 30;
            TrackBarPasswordLength.Minimum = 5;
            TrackBarPasswordLength.Name = "TrackBarPasswordLength";
            TrackBarPasswordLength.Size = new Size(368, 56);
            TrackBarPasswordLength.TabIndex = 4;
            TrackBarPasswordLength.Value = 5;
            // 
            // CheckBoxUseUppercaseLetters
            // 
            CheckBoxUseUppercaseLetters.AutoSize = true;
            CheckBoxUseUppercaseLetters.Location = new Point(9, 89);
            CheckBoxUseUppercaseLetters.Name = "CheckBoxUseUppercaseLetters";
            CheckBoxUseUppercaseLetters.Size = new Size(374, 24);
            CheckBoxUseUppercaseLetters.TabIndex = 3;
            CheckBoxUseUppercaseLetters.Text = "Использовать прописные латинские буквы: A - Z";
            CheckBoxUseUppercaseLetters.UseVisualStyleBackColor = true;
            CheckBoxUseUppercaseLetters.CheckedChanged += CheckBoxUseUppercaseLetters_CheckedChanged;
            // 
            // CheckBoxUseLowercaseLetters
            // 
            CheckBoxUseLowercaseLetters.AutoSize = true;
            CheckBoxUseLowercaseLetters.Location = new Point(9, 66);
            CheckBoxUseLowercaseLetters.Name = "CheckBoxUseLowercaseLetters";
            CheckBoxUseLowercaseLetters.Size = new Size(357, 24);
            CheckBoxUseLowercaseLetters.TabIndex = 2;
            CheckBoxUseLowercaseLetters.Text = "Использовать строчные латинские буквы: a - z";
            CheckBoxUseLowercaseLetters.UseVisualStyleBackColor = true;
            CheckBoxUseLowercaseLetters.CheckedChanged += CheckBoxUseLowercaseLetters_CheckedChanged;
            // 
            // CheckBoxUseDigits
            // 
            CheckBoxUseDigits.AutoSize = true;
            CheckBoxUseDigits.Location = new Point(9, 43);
            CheckBoxUseDigits.Name = "CheckBoxUseDigits";
            CheckBoxUseDigits.Size = new Size(218, 24);
            CheckBoxUseDigits.TabIndex = 1;
            CheckBoxUseDigits.Text = "Использовать цифры: 0 - 9";
            CheckBoxUseDigits.UseVisualStyleBackColor = true;
            CheckBoxUseDigits.CheckedChanged += CheckBoxUseDigits_CheckedChanged;
            // 
            // CheckBoxUseSpecialSymbols
            // 
            CheckBoxUseSpecialSymbols.AutoSize = true;
            CheckBoxUseSpecialSymbols.Location = new Point(9, 20);
            CheckBoxUseSpecialSymbols.Name = "CheckBoxUseSpecialSymbols";
            CheckBoxUseSpecialSymbols.Size = new Size(550, 24);
            CheckBoxUseSpecialSymbols.TabIndex = 0;
            CheckBoxUseSpecialSymbols.Text = "Использовать специальные символы: #  !  $  ;  _  ?  &&  ^  %  @  *  (  )  {  }  [  ]";
            CheckBoxUseSpecialSymbols.UseVisualStyleBackColor = true;
            CheckBoxUseSpecialSymbols.CheckedChanged += CheckBoxUseSpecialSymbols_CheckedChanged;
            // 
            // ButtonGeneratePassword
            // 
            ButtonGeneratePassword.Location = new Point(12, 199);
            ButtonGeneratePassword.Name = "ButtonGeneratePassword";
            ButtonGeneratePassword.Size = new Size(187, 33);
            ButtonGeneratePassword.TabIndex = 1;
            ButtonGeneratePassword.Text = "Сгенерировать пароль";
            ToolTipForControl.SetToolTip(ButtonGeneratePassword, "Сгенерировать надёжный пароль с заданной длинной и используемыми символами");
            ButtonGeneratePassword.UseVisualStyleBackColor = true;
            ButtonGeneratePassword.Click += ButtonGeneratePassword_Click;
            // 
            // ButtonExit
            // 
            ButtonExit.Location = new Point(627, 291);
            ButtonExit.Name = "ButtonExit";
            ButtonExit.Size = new Size(94, 29);
            ButtonExit.TabIndex = 2;
            ButtonExit.Text = "Выход";
            ToolTipForControl.SetToolTip(ButtonExit, "Выйти из программы");
            ButtonExit.UseVisualStyleBackColor = true;
            ButtonExit.Click += ButtonExit_Click;
            // 
            // ButtonClearPassword
            // 
            ButtonClearPassword.Location = new Point(694, 189);
            ButtonClearPassword.Name = "ButtonClearPassword";
            ButtonClearPassword.Size = new Size(33, 33);
            ButtonClearPassword.TabIndex = 3;
            ToolTipForControl.SetToolTip(ButtonClearPassword, "Очистить поле");
            ButtonClearPassword.UseVisualStyleBackColor = true;
            ButtonClearPassword.Click += ButtonClearPassword_Click;
            // 
            // LabelGeneratedPassword
            // 
            LabelGeneratedPassword.AutoSize = true;
            LabelGeneratedPassword.Location = new Point(198, 205);
            LabelGeneratedPassword.Name = "LabelGeneratedPassword";
            LabelGeneratedPassword.Size = new Size(197, 20);
            LabelGeneratedPassword.TabIndex = 4;
            LabelGeneratedPassword.Text = "Сгенерированный пароль:";
            // 
            // LabelWarningMessageTitle
            // 
            LabelWarningMessageTitle.AutoSize = true;
            LabelWarningMessageTitle.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            LabelWarningMessageTitle.ForeColor = Color.FromArgb(192, 0, 0);
            LabelWarningMessageTitle.Location = new Point(12, 251);
            LabelWarningMessageTitle.Name = "LabelWarningMessageTitle";
            LabelWarningMessageTitle.Size = new Size(385, 17);
            LabelWarningMessageTitle.TabIndex = 5;
            LabelWarningMessageTitle.Text = "Рекомендации для генерации надёжного пароля: ";
            // 
            // LabelPasswordCopiedToClipboard
            // 
            LabelPasswordCopiedToClipboard.AutoSize = true;
            LabelPasswordCopiedToClipboard.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold);
            LabelPasswordCopiedToClipboard.ForeColor = Color.Green;
            LabelPasswordCopiedToClipboard.Location = new Point(408, 226);
            LabelPasswordCopiedToClipboard.Name = "LabelPasswordCopiedToClipboard";
            LabelPasswordCopiedToClipboard.Size = new Size(280, 17);
            LabelPasswordCopiedToClipboard.TabIndex = 6;
            LabelPasswordCopiedToClipboard.Text = "Пароль скопирован в буфер обмена";
            // 
            // LabelWarningMessage
            // 
            LabelWarningMessage.ForeColor = Color.FromArgb(192, 0, 0);
            LabelWarningMessage.Location = new Point(12, 275);
            LabelWarningMessage.Name = "LabelWarningMessage";
            LabelWarningMessage.Size = new Size(510, 48);
            LabelWarningMessage.TabIndex = 7;
            LabelWarningMessage.Text = "длина от 8 символов и более, с использованием спецсимволов, цифр, строчных и прописных латинских букв";
            // 
            // TextBoxGeneratedPassword
            // 
            TextBoxGeneratedPassword.Location = new Point(408, 192);
            TextBoxGeneratedPassword.Name = "TextBoxGeneratedPassword";
            TextBoxGeneratedPassword.Size = new Size(280, 27);
            TextBoxGeneratedPassword.TabIndex = 8;
            TextBoxGeneratedPassword.TextChanged += TextBoxGeneratedPassword_TextChanged;
            // 
            // TimerShowLabelCopiedToClipboard
            // 
            TimerShowLabelCopiedToClipboard.Interval = 2000;
            TimerShowLabelCopiedToClipboard.Tick += TimerShowLabelCopiedToClipboard_Tick;
            // 
            // ImageListDefault
            // 
            ImageListDefault.ColorDepth = ColorDepth.Depth32Bit;
            ImageListDefault.ImageSize = new Size(24, 24);
            ImageListDefault.TransparentColor = Color.Transparent;
            // 
            // FrmPasswordGenerator
            // 
            AcceptButton = ButtonGeneratePassword;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ButtonExit;
            ClientSize = new Size(733, 332);
            Controls.Add(TextBoxGeneratedPassword);
            Controls.Add(LabelWarningMessage);
            Controls.Add(LabelPasswordCopiedToClipboard);
            Controls.Add(LabelWarningMessageTitle);
            Controls.Add(LabelGeneratedPassword);
            Controls.Add(ButtonClearPassword);
            Controls.Add(ButtonExit);
            Controls.Add(ButtonGeneratePassword);
            Controls.Add(GroupBoxGenerationParams);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPasswordGenerator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Генератор паролей";
            TopMost = true;
            FormClosing += FrmPasswordGenerator_FormClosing;
            Load += FrmPasswordGenerator_Load;
            GroupBoxGenerationParams.ResumeLayout(false);
            GroupBoxGenerationParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrackBarPasswordLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox GroupBoxGenerationParams;
        private CheckBox CheckBoxUseUppercaseLetters;
        private CheckBox CheckBoxUseLowercaseLetters;
        private CheckBox CheckBoxUseDigits;
        private CheckBox CheckBoxUseSpecialSymbols;
        private Label LabelPasswordLengthValue;
        private Label LabelPasswordLength;
        private TrackBar TrackBarPasswordLength;
        private Button ButtonGeneratePassword;
        private Button ButtonExit;
        private Button ButtonClearPassword;
        private Label LabelGeneratedPassword;
        private Label LabelWarningMessageTitle;
        private Label LabelPasswordCopiedToClipboard;
        private Label LabelWarningMessage;
        private TextBox TextBoxGeneratedPassword;
        private System.Windows.Forms.Timer TimerShowLabelCopiedToClipboard;
        private ImageList ImageListDefault;
        private ToolTip ToolTipForControl;
    }
}
