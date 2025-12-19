namespace TriangleTypeCheck
{
    partial class TriangleTypeCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriangleTypeCheck));
            this.tBoxSizeA = new System.Windows.Forms.TextBox();
            this.tBoxSizeB = new System.Windows.Forms.TextBox();
            this.tBoxSizeC = new System.Windows.Forms.TextBox();
            this.grpBoxInput = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDefine = new System.Windows.Forms.Button();
            this.lblSizeC = new System.Windows.Forms.Label();
            this.lblSizeB = new System.Windows.Forms.Label();
            this.lblSizeA = new System.Windows.Forms.Label();
            this.pnlHead = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblHead = new System.Windows.Forms.Label();
            this.pBoxRes = new System.Windows.Forms.PictureBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.grBoxRes = new System.Windows.Forms.GroupBox();
            this.grpBoxInput.SuspendLayout();
            this.pnlHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRes)).BeginInit();
            this.grBoxRes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBoxSizeA
            // 
            this.tBoxSizeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxSizeA.Location = new System.Drawing.Point(128, 43);
            this.tBoxSizeA.Name = "tBoxSizeA";
            this.tBoxSizeA.Size = new System.Drawing.Size(186, 29);
            this.tBoxSizeA.TabIndex = 0;
            // 
            // tBoxSizeB
            // 
            this.tBoxSizeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxSizeB.Location = new System.Drawing.Point(128, 77);
            this.tBoxSizeB.Name = "tBoxSizeB";
            this.tBoxSizeB.Size = new System.Drawing.Size(186, 29);
            this.tBoxSizeB.TabIndex = 1;
            // 
            // tBoxSizeC
            // 
            this.tBoxSizeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBoxSizeC.Location = new System.Drawing.Point(128, 112);
            this.tBoxSizeC.Name = "tBoxSizeC";
            this.tBoxSizeC.Size = new System.Drawing.Size(186, 29);
            this.tBoxSizeC.TabIndex = 2;
            // 
            // grpBoxInput
            // 
            this.grpBoxInput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpBoxInput.Controls.Add(this.btnClear);
            this.grpBoxInput.Controls.Add(this.btnDefine);
            this.grpBoxInput.Controls.Add(this.lblSizeC);
            this.grpBoxInput.Controls.Add(this.lblSizeB);
            this.grpBoxInput.Controls.Add(this.lblSizeA);
            this.grpBoxInput.Controls.Add(this.tBoxSizeA);
            this.grpBoxInput.Controls.Add(this.tBoxSizeC);
            this.grpBoxInput.Controls.Add(this.tBoxSizeB);
            this.grpBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpBoxInput.Location = new System.Drawing.Point(12, 136);
            this.grpBoxInput.Name = "grpBoxInput";
            this.grpBoxInput.Size = new System.Drawing.Size(336, 239);
            this.grpBoxInput.TabIndex = 3;
            this.grpBoxInput.TabStop = false;
            this.grpBoxInput.Text = "Входные данные";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.Window;
            this.btnClear.Location = new System.Drawing.Point(169, 165);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(145, 52);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDefine
            // 
            this.btnDefine.BackColor = System.Drawing.SystemColors.Window;
            this.btnDefine.Location = new System.Drawing.Point(10, 165);
            this.btnDefine.Name = "btnDefine";
            this.btnDefine.Size = new System.Drawing.Size(145, 52);
            this.btnDefine.TabIndex = 5;
            this.btnDefine.Text = "Определить";
            this.btnDefine.UseVisualStyleBackColor = false;
            this.btnDefine.Click += new System.EventHandler(this.btnDefine_Click);
            // 
            // lblSizeC
            // 
            this.lblSizeC.AutoSize = true;
            this.lblSizeC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeC.Location = new System.Drawing.Point(7, 115);
            this.lblSizeC.Name = "lblSizeC";
            this.lblSizeC.Size = new System.Drawing.Size(110, 24);
            this.lblSizeC.TabIndex = 5;
            this.lblSizeC.Text = "Сторона C:";
            // 
            // lblSizeB
            // 
            this.lblSizeB.AutoSize = true;
            this.lblSizeB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeB.Location = new System.Drawing.Point(6, 80);
            this.lblSizeB.Name = "lblSizeB";
            this.lblSizeB.Size = new System.Drawing.Size(109, 24);
            this.lblSizeB.TabIndex = 4;
            this.lblSizeB.Text = "Сторона B:";
            // 
            // lblSizeA
            // 
            this.lblSizeA.AutoSize = true;
            this.lblSizeA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSizeA.Location = new System.Drawing.Point(6, 46);
            this.lblSizeA.Name = "lblSizeA";
            this.lblSizeA.Size = new System.Drawing.Size(110, 24);
            this.lblSizeA.TabIndex = 3;
            this.lblSizeA.Text = "Сторона A:";
            // 
            // pnlHead
            // 
            this.pnlHead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlHead.Controls.Add(this.btnExit);
            this.pnlHead.Controls.Add(this.lblHead);
            this.pnlHead.Location = new System.Drawing.Point(-2, -4);
            this.pnlHead.Name = "pnlHead";
            this.pnlHead.Size = new System.Drawing.Size(788, 105);
            this.pnlHead.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.Window;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(616, 16);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(158, 70);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHead.Location = new System.Drawing.Point(7, 30);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(593, 42);
            this.lblHead.TabIndex = 0;
            this.lblHead.Text = "Определение типа треугольника";
            // 
            // pBoxRes
            // 
            this.pBoxRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBoxRes.ImageLocation = "";
            this.pBoxRes.Location = new System.Drawing.Point(35, 30);
            this.pBoxRes.Name = "pBoxRes";
            this.pBoxRes.Size = new System.Drawing.Size(306, 182);
            this.pBoxRes.TabIndex = 4;
            this.pBoxRes.TabStop = false;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRes.Location = new System.Drawing.Point(30, 213);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(297, 25);
            this.lblRes.TabIndex = 6;
            this.lblRes.Text = "Ожидание ввода значений...";
            // 
            // grBoxRes
            // 
            this.grBoxRes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grBoxRes.Controls.Add(this.pBoxRes);
            this.grBoxRes.Controls.Add(this.lblRes);
            this.grBoxRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grBoxRes.Location = new System.Drawing.Point(377, 136);
            this.grBoxRes.Name = "grBoxRes";
            this.grBoxRes.Size = new System.Drawing.Size(374, 241);
            this.grBoxRes.TabIndex = 7;
            this.grBoxRes.TabStop = false;
            this.grBoxRes.Text = "Результат";
            // 
            // TriangleTypeCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.grBoxRes);
            this.Controls.Add(this.pnlHead);
            this.Controls.Add(this.grpBoxInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TriangleTypeCheck";
            this.Text = "Triangle Type Check";
            this.grpBoxInput.ResumeLayout(false);
            this.grpBoxInput.PerformLayout();
            this.pnlHead.ResumeLayout(false);
            this.pnlHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxRes)).EndInit();
            this.grBoxRes.ResumeLayout(false);
            this.grBoxRes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxSizeA;
        private System.Windows.Forms.TextBox tBoxSizeB;
        private System.Windows.Forms.TextBox tBoxSizeC;
        private System.Windows.Forms.GroupBox grpBoxInput;
        private System.Windows.Forms.Panel pnlHead;
        private System.Windows.Forms.Label lblSizeC;
        private System.Windows.Forms.Label lblSizeB;
        private System.Windows.Forms.Label lblSizeA;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.PictureBox pBoxRes;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDefine;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.GroupBox grBoxRes;
    }
}

