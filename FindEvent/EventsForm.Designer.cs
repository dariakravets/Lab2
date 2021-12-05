namespace FindEvent
{
    partial class EventsForm
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
            this.checkEventName = new System.Windows.Forms.CheckBox();
            this.checkPersonName = new System.Windows.Forms.CheckBox();
            this.checkFaculty = new System.Windows.Forms.CheckBox();
            this.checkDepartment = new System.Windows.Forms.CheckBox();
            this.checkResponsible = new System.Windows.Forms.CheckBox();
            this.checkDoer = new System.Windows.Forms.CheckBox();
            this.checkDeadline = new System.Windows.Forms.CheckBox();
            this.checkTime = new System.Windows.Forms.CheckBox();
            this.checkPlace = new System.Windows.Forms.CheckBox();
            this.checkCharacteristic = new System.Windows.Forms.CheckBox();
            this.comboBoxEventName = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonName = new System.Windows.Forms.ComboBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.comboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.comboBoxResponsible = new System.Windows.Forms.ComboBox();
            this.comboBoxDoer = new System.Windows.Forms.ComboBox();
            this.comboBoxDeadline = new System.Windows.Forms.ComboBox();
            this.comboBoxTime = new System.Windows.Forms.ComboBox();
            this.comboBoxPlace = new System.Windows.Forms.ComboBox();
            this.comboBoxCharacteristic = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButtonDOM = new System.Windows.Forms.RadioButton();
            this.radioButtonSAX = new System.Windows.Forms.RadioButton();
            this.radioButtonLinqToXML = new System.Windows.Forms.RadioButton();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonTransform = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkEventName
            // 
            this.checkEventName.AutoSize = true;
            this.checkEventName.Location = new System.Drawing.Point(25, 40);
            this.checkEventName.Name = "checkEventName";
            this.checkEventName.Size = new System.Drawing.Size(118, 21);
            this.checkEventName.TabIndex = 0;
            this.checkEventName.Text = "Назва заходу";
            this.checkEventName.UseVisualStyleBackColor = true;
            // 
            // checkPersonName
            // 
            this.checkPersonName.AutoSize = true;
            this.checkPersonName.Location = new System.Drawing.Point(25, 80);
            this.checkPersonName.Name = "checkPersonName";
            this.checkPersonName.Size = new System.Drawing.Size(65, 21);
            this.checkPersonName.TabIndex = 1;
            this.checkPersonName.Text = "П.І.П.";
            this.checkPersonName.UseVisualStyleBackColor = true;
            // 
            // checkFaculty
            // 
            this.checkFaculty.AutoSize = true;
            this.checkFaculty.Location = new System.Drawing.Point(25, 120);
            this.checkFaculty.Name = "checkFaculty";
            this.checkFaculty.Size = new System.Drawing.Size(102, 21);
            this.checkFaculty.TabIndex = 2;
            this.checkFaculty.Text = "Факультет";
            this.checkFaculty.UseVisualStyleBackColor = true;
            // 
            // checkDepartment
            // 
            this.checkDepartment.AutoSize = true;
            this.checkDepartment.Location = new System.Drawing.Point(25, 160);
            this.checkDepartment.Name = "checkDepartment";
            this.checkDepartment.Size = new System.Drawing.Size(90, 21);
            this.checkDepartment.TabIndex = 3;
            this.checkDepartment.Text = "Кафедра";
            this.checkDepartment.UseVisualStyleBackColor = true;
            // 
            // checkResponsible
            // 
            this.checkResponsible.AutoSize = true;
            this.checkResponsible.Location = new System.Drawing.Point(25, 200);
            this.checkResponsible.Name = "checkResponsible";
            this.checkResponsible.Size = new System.Drawing.Size(166, 21);
            this.checkResponsible.TabIndex = 4;
            this.checkResponsible.Text = "Відповідальна особа";
            this.checkResponsible.UseVisualStyleBackColor = true;
            // 
            // checkDoer
            // 
            this.checkDoer.AutoSize = true;
            this.checkDoer.Location = new System.Drawing.Point(25, 240);
            this.checkDoer.Name = "checkDoer";
            this.checkDoer.Size = new System.Drawing.Size(183, 21);
            this.checkDoer.TabIndex = 5;
            this.checkDoer.Text = "Виконавець доручення";
            this.checkDoer.UseVisualStyleBackColor = true;
            // 
            // checkDeadline
            // 
            this.checkDeadline.AutoSize = true;
            this.checkDeadline.Location = new System.Drawing.Point(25, 280);
            this.checkDeadline.Name = "checkDeadline";
            this.checkDeadline.Size = new System.Drawing.Size(149, 21);
            this.checkDeadline.TabIndex = 6;
            this.checkDeadline.Text = "Термін виконання";
            this.checkDeadline.UseVisualStyleBackColor = true;
            // 
            // checkTime
            // 
            this.checkTime.AutoSize = true;
            this.checkTime.Location = new System.Drawing.Point(25, 320);
            this.checkTime.Name = "checkTime";
            this.checkTime.Size = new System.Drawing.Size(55, 21);
            this.checkTime.TabIndex = 7;
            this.checkTime.Text = "Час";
            this.checkTime.UseVisualStyleBackColor = true;
            // 
            // checkPlace
            // 
            this.checkPlace.AutoSize = true;
            this.checkPlace.Location = new System.Drawing.Point(25, 360);
            this.checkPlace.Name = "checkPlace";
            this.checkPlace.Size = new System.Drawing.Size(150, 21);
            this.checkPlace.TabIndex = 8;
            this.checkPlace.Text = "Місце проведення";
            this.checkPlace.UseVisualStyleBackColor = true;
            // 
            // checkCharacteristic
            // 
            this.checkCharacteristic.AutoSize = true;
            this.checkCharacteristic.Location = new System.Drawing.Point(25, 400);
            this.checkCharacteristic.Name = "checkCharacteristic";
            this.checkCharacteristic.Size = new System.Drawing.Size(194, 21);
            this.checkCharacteristic.TabIndex = 9;
            this.checkCharacteristic.Text = "Коротка характеристика";
            this.checkCharacteristic.UseVisualStyleBackColor = true;
            // 
            // comboBoxEventName
            // 
            this.comboBoxEventName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEventName.FormattingEnabled = true;
            this.comboBoxEventName.Location = new System.Drawing.Point(241, 38);
            this.comboBoxEventName.Name = "comboBoxEventName";
            this.comboBoxEventName.Size = new System.Drawing.Size(345, 24);
            this.comboBoxEventName.TabIndex = 10;
            // 
            // comboBoxPersonName
            // 
            this.comboBoxPersonName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonName.FormattingEnabled = true;
            this.comboBoxPersonName.Location = new System.Drawing.Point(241, 78);
            this.comboBoxPersonName.Name = "comboBoxPersonName";
            this.comboBoxPersonName.Size = new System.Drawing.Size(345, 24);
            this.comboBoxPersonName.TabIndex = 11;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(241, 118);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(345, 24);
            this.comboBoxFaculty.TabIndex = 12;
            // 
            // comboBoxDepartment
            // 
            this.comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartment.FormattingEnabled = true;
            this.comboBoxDepartment.Location = new System.Drawing.Point(241, 158);
            this.comboBoxDepartment.Name = "comboBoxDepartment";
            this.comboBoxDepartment.Size = new System.Drawing.Size(345, 24);
            this.comboBoxDepartment.TabIndex = 13;
            // 
            // comboBoxResponsible
            // 
            this.comboBoxResponsible.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxResponsible.FormattingEnabled = true;
            this.comboBoxResponsible.Location = new System.Drawing.Point(241, 198);
            this.comboBoxResponsible.Name = "comboBoxResponsible";
            this.comboBoxResponsible.Size = new System.Drawing.Size(345, 24);
            this.comboBoxResponsible.TabIndex = 14;
            // 
            // comboBoxDoer
            // 
            this.comboBoxDoer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDoer.FormattingEnabled = true;
            this.comboBoxDoer.Location = new System.Drawing.Point(241, 238);
            this.comboBoxDoer.Name = "comboBoxDoer";
            this.comboBoxDoer.Size = new System.Drawing.Size(345, 24);
            this.comboBoxDoer.TabIndex = 15;
            // 
            // comboBoxDeadline
            // 
            this.comboBoxDeadline.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDeadline.FormattingEnabled = true;
            this.comboBoxDeadline.Location = new System.Drawing.Point(241, 278);
            this.comboBoxDeadline.Name = "comboBoxDeadline";
            this.comboBoxDeadline.Size = new System.Drawing.Size(345, 24);
            this.comboBoxDeadline.TabIndex = 16;
            // 
            // comboBoxTime
            // 
            this.comboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTime.FormattingEnabled = true;
            this.comboBoxTime.Location = new System.Drawing.Point(241, 318);
            this.comboBoxTime.Name = "comboBoxTime";
            this.comboBoxTime.Size = new System.Drawing.Size(345, 24);
            this.comboBoxTime.TabIndex = 17;
            // 
            // comboBoxPlace
            // 
            this.comboBoxPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPlace.FormattingEnabled = true;
            this.comboBoxPlace.Location = new System.Drawing.Point(241, 358);
            this.comboBoxPlace.Name = "comboBoxPlace";
            this.comboBoxPlace.Size = new System.Drawing.Size(345, 24);
            this.comboBoxPlace.TabIndex = 18;
            // 
            // comboBoxCharacteristic
            // 
            this.comboBoxCharacteristic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCharacteristic.FormattingEnabled = true;
            this.comboBoxCharacteristic.Location = new System.Drawing.Point(241, 398);
            this.comboBoxCharacteristic.Name = "comboBoxCharacteristic";
            this.comboBoxCharacteristic.Size = new System.Drawing.Size(345, 24);
            this.comboBoxCharacteristic.TabIndex = 19;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(619, 38);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(481, 527);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // radioButtonDOM
            // 
            this.radioButtonDOM.AutoSize = true;
            this.radioButtonDOM.Location = new System.Drawing.Point(25, 460);
            this.radioButtonDOM.Name = "radioButtonDOM";
            this.radioButtonDOM.Size = new System.Drawing.Size(61, 21);
            this.radioButtonDOM.TabIndex = 21;
            this.radioButtonDOM.TabStop = true;
            this.radioButtonDOM.Text = "DOM";
            this.radioButtonDOM.UseVisualStyleBackColor = true;
            // 
            // radioButtonSAX
            // 
            this.radioButtonSAX.AutoSize = true;
            this.radioButtonSAX.Location = new System.Drawing.Point(25, 501);
            this.radioButtonSAX.Name = "radioButtonSAX";
            this.radioButtonSAX.Size = new System.Drawing.Size(56, 21);
            this.radioButtonSAX.TabIndex = 22;
            this.radioButtonSAX.TabStop = true;
            this.radioButtonSAX.Text = "SAX";
            this.radioButtonSAX.UseVisualStyleBackColor = true;
            // 
            // radioButtonLinqToXML
            // 
            this.radioButtonLinqToXML.AutoSize = true;
            this.radioButtonLinqToXML.Location = new System.Drawing.Point(25, 544);
            this.radioButtonLinqToXML.Name = "radioButtonLinqToXML";
            this.radioButtonLinqToXML.Size = new System.Drawing.Size(109, 21);
            this.radioButtonLinqToXML.TabIndex = 23;
            this.radioButtonLinqToXML.TabStop = true;
            this.radioButtonLinqToXML.Text = "LINQ to XML";
            this.radioButtonLinqToXML.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(81, 622);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(81, 28);
            this.buttonSearch.TabIndex = 24;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonTransform
            // 
            this.buttonTransform.Location = new System.Drawing.Point(183, 622);
            this.buttonTransform.Name = "buttonTransform";
            this.buttonTransform.Size = new System.Drawing.Size(100, 28);
            this.buttonTransform.TabIndex = 25;
            this.buttonTransform.Text = "В HTML";
            this.buttonTransform.UseVisualStyleBackColor = true;
            this.buttonTransform.Click += new System.EventHandler(this.buttonTransform_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(303, 622);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(99, 28);
            this.buttonClear.TabIndex = 26;
            this.buttonClear.Text = "Очистити";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 677);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTransform);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.radioButtonLinqToXML);
            this.Controls.Add(this.radioButtonSAX);
            this.Controls.Add(this.radioButtonDOM);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBoxCharacteristic);
            this.Controls.Add(this.comboBoxPlace);
            this.Controls.Add(this.comboBoxTime);
            this.Controls.Add(this.comboBoxDeadline);
            this.Controls.Add(this.comboBoxDoer);
            this.Controls.Add(this.comboBoxResponsible);
            this.Controls.Add(this.comboBoxDepartment);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.comboBoxPersonName);
            this.Controls.Add(this.comboBoxEventName);
            this.Controls.Add(this.checkCharacteristic);
            this.Controls.Add(this.checkPlace);
            this.Controls.Add(this.checkTime);
            this.Controls.Add(this.checkDeadline);
            this.Controls.Add(this.checkDoer);
            this.Controls.Add(this.checkResponsible);
            this.Controls.Add(this.checkDepartment);
            this.Controls.Add(this.checkFaculty);
            this.Controls.Add(this.checkPersonName);
            this.Controls.Add(this.checkEventName);
            this.Name = "EventsForm";
            this.Text = "FacultyDay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkEventName;
        private System.Windows.Forms.CheckBox checkPersonName;
        private System.Windows.Forms.CheckBox checkFaculty;
        private System.Windows.Forms.CheckBox checkDepartment;
        private System.Windows.Forms.CheckBox checkResponsible;
        private System.Windows.Forms.CheckBox checkDoer;
        private System.Windows.Forms.CheckBox checkDeadline;
        private System.Windows.Forms.CheckBox checkTime;
        private System.Windows.Forms.CheckBox checkPlace;
        private System.Windows.Forms.CheckBox checkCharacteristic;
        private System.Windows.Forms.ComboBox comboBoxEventName;
        private System.Windows.Forms.ComboBox comboBoxPersonName;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.ComboBox comboBoxResponsible;
        private System.Windows.Forms.ComboBox comboBoxDoer;
        private System.Windows.Forms.ComboBox comboBoxDeadline;
        private System.Windows.Forms.ComboBox comboBoxTime;
        private System.Windows.Forms.ComboBox comboBoxPlace;
        private System.Windows.Forms.ComboBox comboBoxCharacteristic;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButtonDOM;
        private System.Windows.Forms.RadioButton radioButtonSAX;
        private System.Windows.Forms.RadioButton radioButtonLinqToXML;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonTransform;
        private System.Windows.Forms.Button buttonClear;
    }
}

