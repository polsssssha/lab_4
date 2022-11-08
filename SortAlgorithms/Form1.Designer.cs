using System;
using System.Windows.Forms;

namespace SortAlgorithms
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

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.FillButton = new System.Windows.Forms.Button();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.CompareLbl = new System.Windows.Forms.Label();
            this.SwopLbl = new System.Windows.Forms.Label();
            this.SelectionSortBtn = new System.Windows.Forms.Button();
            this.QuickSortBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.AddTextBox);
            
            CreatePanel(panel:panel1, panelIndex:0, name:"panel1", x:0, y:0, width:333, height:61);
            
            // 
            // label1
            // 
            CreateLbl(label: this.label1, name: "label1", text:"Добавить число", lablIndex:2, x:12, y:9);
            
            // 
            // AddButton
            // 
            CreateBtn(x: 246, y:24, btnName:"AddButton", tabIndex:1, btnText:"Добавить", handler:this.AddButton_Click, btn:this.AddButton);
            
            // 
            // ClearButton
            // 
            CreateBtn(x: 246, y:57, btnName:"ClearButton", tabIndex:1, btnText:"Очистить", handler:this.Clear, btn:this.ClearBtn);
            
            // 
            // AddTextBox
            // 
            CreateTextBox(textBox:this.AddTextBox, name:"AddTextBox");
            
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Controls.Add(this.FillTextBox);
            
            CreatePanel(panel:this.panel2, panelIndex:3, name:"panel2", x:0, y:67, width:333, height:61);
            
            // 
            // label3
            // 
            CreateLbl(label: this.label3, name: "label3", text:"Заполнить случайными числами", lablIndex:2, x:12, y:9);
            
            // 
            // FillButton
            // 
            CreateBtn(x: 246, y:24, btnName:"FillButton", tabIndex:1, btnText:"Заполнить", handler:this.FillButton_Click, btn:this.FillButton);
            
            // 
            // FillTextBox
            // 
            CreateTextBox(textBox:this.FillTextBox, name:"FillTextBox");
            
            // 
            // panel3
            // 
            this.panel3.Anchor =
                ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top |
                                                        System.Windows.Forms.AnchorStyles.Left)
                                                       | System.Windows.Forms.AnchorStyles.Right)));
            
            CreatePanel(panel:this.panel3, panelIndex:4, name:"panel3", x:339, y:0, width:694, height:128);
            
            // 
            // TimeLbl
            // 
            CreateLbl(label: this.TimeLbl, name: "TimeLbl", text:"Время (мс):", lablIndex:6, x:9, y:160);
            
            // 
            // CompareLbl
            // 
            CreateLbl(label: this.CompareLbl, name: "CompareLbl", text:"Количество Сравнений: ", lablIndex:7, x:9, y:182);
            
            // 
            // SwopLbl
            // 
            CreateLbl(label: this.SwopLbl, name: "SwopLbl", text:"Количество обменов: ", lablIndex:8, x:9, y:204);
            
            // 
            // SelectionSortBtn
            // 
            CreateBtn(x: 12, y:134, btnName:"SelectionSortBtn", tabIndex:12, btnText:"SelectionSort", handler:this.SelectionSortBtn_Click, btn:this.SelectionSortBtn);
            
            // 
            // QuickSortBtn
            // 
            CreateBtn(x: 90, y:134, btnName:"QuickSortBtn", tabIndex:19, btnText:"QuickSort", handler:this.QuickSortBtn_Click, btn:this.QuickSortBtn);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 242);
            this.Controls.Add(this.QuickSortBtn);
            this.Controls.Add(this.SelectionSortBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SwopLbl);
            this.Controls.Add(this.CompareLbl);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CreateTextBox(TextBox textBox,string name)
        {
            textBox.Location = new System.Drawing.Point(15, 25);
            textBox.Name = name;
            textBox.Size = new System.Drawing.Size(228, 20);
            textBox.TabIndex = 0;
        }

        private void CreatePanel(Panel panel, string name, int panelIndex, int x, int y, int width, int height)
        {
            panel.Location = new System.Drawing.Point(x, y);
            panel.Name = name;
            panel.Size = new System.Drawing.Size(width, height);
            panel.TabIndex = panelIndex;
        }

        private void CreateBtn(Button btn, string btnName, int tabIndex, string btnText, EventHandler handler, int x, int y)
        {
            btn.Location = new System.Drawing.Point(x, y);
            btn.Name = btnName;
            btn.Size = new System.Drawing.Size(75, 23);
            btn.TabIndex = tabIndex;
            btn.Text = btnText;
            btn.UseVisualStyleBackColor = true;
            btn.Click += new System.EventHandler(handler);
        }

        private void CreateLbl(Label label, string text, string name, int x, int y, int lablIndex)
        {
            label.AutoSize = true;
            label.Location = new System.Drawing.Point(x, y);
            label.Name = name;
            label.Size = new System.Drawing.Size(119, 13);
            label.TabIndex = lablIndex;
            label.Text = text;
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Panel panel3;     
        private System.Windows.Forms.Label TimeLbl;
        private System.Windows.Forms.Label CompareLbl;
        private System.Windows.Forms.Label SwopLbl;       
        private System.Windows.Forms.Button SelectionSortBtn;      
        private System.Windows.Forms.Button QuickSortBtn;
        private System.Windows.Forms.Button ClearBtn;
    }
}

