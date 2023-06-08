namespace WindowsFormsApp6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nextPersonTime = new System.Windows.Forms.Label();
            this.queueSize = new System.Windows.Forms.Label();
            this.readySize = new System.Windows.Forms.Label();
            this.startBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.operatorsNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.freeOperators = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.operatorsNum)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nextPersonTime
            // 
            this.nextPersonTime.AutoSize = true;
            this.nextPersonTime.Location = new System.Drawing.Point(373, 74);
            this.nextPersonTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nextPersonTime.Name = "nextPersonTime";
            this.nextPersonTime.Size = new System.Drawing.Size(18, 20);
            this.nextPersonTime.TabIndex = 0;
            this.nextPersonTime.Text = "0";
            // 
            // queueSize
            // 
            this.queueSize.AutoSize = true;
            this.queueSize.Location = new System.Drawing.Point(373, 125);
            this.queueSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.queueSize.Name = "queueSize";
            this.queueSize.Size = new System.Drawing.Size(18, 20);
            this.queueSize.TabIndex = 1;
            this.queueSize.Text = "0";
            // 
            // readySize
            // 
            this.readySize.AutoSize = true;
            this.readySize.Location = new System.Drawing.Point(373, 179);
            this.readySize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.readySize.Name = "readySize";
            this.readySize.Size = new System.Drawing.Size(18, 20);
            this.readySize.TabIndex = 2;
            this.readySize.Text = "0";
            // 
            // startBut
            // 
            this.startBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBut.Location = new System.Drawing.Point(425, 268);
            this.startBut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.startBut.Name = "startBut";
            this.startBut.Size = new System.Drawing.Size(136, 56);
            this.startBut.TabIndex = 6;
            this.startBut.Text = "Start";
            this.startBut.UseVisualStyleBackColor = true;
            this.startBut.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Время до следующего клиента:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(32, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Количество людей в очереди:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(32, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(315, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Количество обслуженных клиентов:";
            // 
            // operatorsNum
            // 
            this.operatorsNum.Location = new System.Drawing.Point(730, 72);
            this.operatorsNum.Name = "operatorsNum";
            this.operatorsNum.Size = new System.Drawing.Size(76, 26);
            this.operatorsNum.TabIndex = 10;
            this.operatorsNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Количество операторов:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(284, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Количество свободных операторов:";
            // 
            // freeOperators
            // 
            this.freeOperators.AutoSize = true;
            this.freeOperators.Location = new System.Drawing.Point(812, 125);
            this.freeOperators.Name = "freeOperators";
            this.freeOperators.Size = new System.Drawing.Size(18, 20);
            this.freeOperators.TabIndex = 13;
            this.freeOperators.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.freeOperators);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.operatorsNum);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startBut);
            this.Controls.Add(this.readySize);
            this.Controls.Add(this.queueSize);
            this.Controls.Add(this.nextPersonTime);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.operatorsNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label nextPersonTime;
        private System.Windows.Forms.Label queueSize;
        private System.Windows.Forms.Label readySize;
        private System.Windows.Forms.Button startBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown operatorsNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label freeOperators;
    }
}

