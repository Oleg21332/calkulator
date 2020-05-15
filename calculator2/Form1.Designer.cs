namespace calculator2
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CB1 = new System.Windows.Forms.ComboBox();
            this.kolvo = new System.Windows.Forms.TextBox();
            this.V = new System.Windows.Forms.Button();
            this.CB2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.metr = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.stroka = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checksim = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.znak = new System.Windows.Forms.Label();
            this.hex = new System.Windows.Forms.Button();
            this.bin = new System.Windows.Forms.Button();
            this.oct = new System.Windows.Forms.Button();
            this.dec = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.squart = new System.Windows.Forms.Button();
            this.ctg = new System.Windows.Forms.Button();
            this.tg = new System.Windows.Forms.Button();
            this.cos = new System.Windows.Forms.Button();
            this.sin = new System.Windows.Forms.Button();
            this.enter = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Aqua;
            this.tabPage3.BackgroundImage = global::calculator2.Properties.Resources._413930;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage3.Controls.Add(this.textBox5);
            this.tabPage3.Controls.Add(this.textBox4);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.CB1);
            this.tabPage3.Controls.Add(this.kolvo);
            this.tabPage3.Controls.Add(this.V);
            this.tabPage3.Controls.Add(this.CB2);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.metr);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(365, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Конвертер";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Chartreuse;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Location = new System.Drawing.Point(1, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 18;
            this.label1.Text = "Количество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.DarkOrange;
            this.label7.Location = new System.Drawing.Point(10, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 17;
            // 
            // CB1
            // 
            this.CB1.BackColor = System.Drawing.Color.OrangeRed;
            this.CB1.FormattingEnabled = true;
            this.CB1.Items.AddRange(new object[] {
            "попугаев",
            "метров",
            "удавов"});
            this.CB1.Location = new System.Drawing.Point(51, 24);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(121, 32);
            this.CB1.TabIndex = 16;
            this.CB1.SelectedIndexChanged += new System.EventHandler(this.CB1_SelectedIndexChanged);
            // 
            // kolvo
            // 
            this.kolvo.BackColor = System.Drawing.Color.Chartreuse;
            this.kolvo.Location = new System.Drawing.Point(1, 94);
            this.kolvo.Multiline = true;
            this.kolvo.Name = "kolvo";
            this.kolvo.Size = new System.Drawing.Size(102, 34);
            this.kolvo.TabIndex = 15;
            this.kolvo.TextChanged += new System.EventHandler(this.kolvo_TextChanged);
            // 
            // V
            // 
            this.V.BackColor = System.Drawing.Color.Red;
            this.V.Location = new System.Drawing.Point(172, 62);
            this.V.Name = "V";
            this.V.Size = new System.Drawing.Size(121, 34);
            this.V.TabIndex = 13;
            this.V.Text = "Рассчитать";
            this.V.UseVisualStyleBackColor = false;
            this.V.Click += new System.EventHandler(this.V_Click);
            // 
            // CB2
            // 
            this.CB2.BackColor = System.Drawing.Color.Yellow;
            this.CB2.FormattingEnabled = true;
            this.CB2.Items.AddRange(new object[] {
            "попугаи",
            "метры",
            "удавы"});
            this.CB2.Location = new System.Drawing.Point(206, 21);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(121, 32);
            this.CB2.TabIndex = 12;
            this.CB2.SelectedIndexChanged += new System.EventHandler(this.CB2_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(178, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "В";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(10, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Из";
            // 
            // metr
            // 
            this.metr.AutoSize = true;
            this.metr.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.metr.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metr.ForeColor = System.Drawing.Color.GreenYellow;
            this.metr.Location = new System.Drawing.Point(202, 387);
            this.metr.Name = "metr";
            this.metr.Size = new System.Drawing.Size(0, 20);
            this.metr.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Aqua;
            this.tabPage2.Controls.Add(this.stroka);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.checksim);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(365, 414);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Строковый калькулятор";
            // 
            // stroka
            // 
            this.stroka.AutoSize = true;
            this.stroka.BackColor = System.Drawing.Color.White;
            this.stroka.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stroka.Location = new System.Drawing.Point(120, 123);
            this.stroka.Name = "stroka";
            this.stroka.Size = new System.Drawing.Size(0, 24);
            this.stroka.TabIndex = 8;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(67, 337);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(231, 31);
            this.button6.TabIndex = 7;
            this.button6.Text = "Статистика";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(67, 300);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(231, 31);
            this.button5.TabIndex = 6;
            this.button5.Text = "Исправление ошибок в строке";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(231, 31);
            this.button4.TabIndex = 5;
            this.button4.Text = "Выделение из строки подстроки";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(231, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Преобразовать в строчные";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(231, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Преобразовать в заглавные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checksim
            // 
            this.checksim.BackColor = System.Drawing.SystemColors.Control;
            this.checksim.Location = new System.Drawing.Point(67, 152);
            this.checksim.Name = "checksim";
            this.checksim.Size = new System.Drawing.Size(231, 31);
            this.checksim.TabIndex = 2;
            this.checksim.Text = "Определить длину";
            this.checksim.UseVisualStyleBackColor = false;
            this.checksim.Click += new System.EventHandler(this.checksim_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(32, 79);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(301, 39);
            this.textBox3.TabIndex = 1;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(32, 17);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(301, 39);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Aqua;
            this.tabPage1.Controls.Add(this.znak);
            this.tabPage1.Controls.Add(this.hex);
            this.tabPage1.Controls.Add(this.bin);
            this.tabPage1.Controls.Add(this.oct);
            this.tabPage1.Controls.Add(this.dec);
            this.tabPage1.Controls.Add(this.log);
            this.tabPage1.Controls.Add(this.exp);
            this.tabPage1.Controls.Add(this.sqrt);
            this.tabPage1.Controls.Add(this.squart);
            this.tabPage1.Controls.Add(this.ctg);
            this.tabPage1.Controls.Add(this.tg);
            this.tabPage1.Controls.Add(this.cos);
            this.tabPage1.Controls.Add(this.sin);
            this.tabPage1.Controls.Add(this.enter);
            this.tabPage1.Controls.Add(this.zero);
            this.tabPage1.Controls.Add(this.clear);
            this.tabPage1.Controls.Add(this.division);
            this.tabPage1.Controls.Add(this.multiplication);
            this.tabPage1.Controls.Add(this.minus);
            this.tabPage1.Controls.Add(this.plus);
            this.tabPage1.Controls.Add(this.eight);
            this.tabPage1.Controls.Add(this.seven);
            this.tabPage1.Controls.Add(this.six);
            this.tabPage1.Controls.Add(this.nine);
            this.tabPage1.Controls.Add(this.five);
            this.tabPage1.Controls.Add(this.four);
            this.tabPage1.Controls.Add(this.three);
            this.tabPage1.Controls.Add(this.two);
            this.tabPage1.Controls.Add(this.one);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(365, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Числовой калькулятор";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // znak
            // 
            this.znak.AutoSize = true;
            this.znak.BackColor = System.Drawing.Color.White;
            this.znak.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.znak.Location = new System.Drawing.Point(20, 9);
            this.znak.Name = "znak";
            this.znak.Size = new System.Drawing.Size(0, 24);
            this.znak.TabIndex = 17;
            // 
            // hex
            // 
            this.hex.BackColor = System.Drawing.SystemColors.Control;
            this.hex.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hex.Location = new System.Drawing.Point(15, 352);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(50, 50);
            this.hex.TabIndex = 55;
            this.hex.Text = ":16";
            this.hex.UseVisualStyleBackColor = true;
            this.hex.Click += new System.EventHandler(this.hex_Click);
            // 
            // bin
            // 
            this.bin.BackColor = System.Drawing.SystemColors.Control;
            this.bin.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bin.Location = new System.Drawing.Point(183, 352);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(50, 50);
            this.bin.TabIndex = 54;
            this.bin.Text = ":2";
            this.bin.UseVisualStyleBackColor = true;
            this.bin.Click += new System.EventHandler(this.bin_Click);
            // 
            // oct
            // 
            this.oct.BackColor = System.Drawing.SystemColors.Control;
            this.oct.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.oct.Location = new System.Drawing.Point(127, 352);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(50, 50);
            this.oct.TabIndex = 53;
            this.oct.Text = ":8";
            this.oct.UseVisualStyleBackColor = true;
            this.oct.Click += new System.EventHandler(this.oct_Click);
            // 
            // dec
            // 
            this.dec.BackColor = System.Drawing.SystemColors.Control;
            this.dec.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dec.Location = new System.Drawing.Point(71, 352);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(50, 50);
            this.dec.TabIndex = 52;
            this.dec.Text = ":10";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.Click += new System.EventHandler(this.Dec_Click);
            // 
            // log
            // 
            this.log.BackColor = System.Drawing.SystemColors.Control;
            this.log.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.log.Location = new System.Drawing.Point(295, 184);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(50, 50);
            this.log.TabIndex = 51;
            this.log.Text = "Log";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click_1);
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.SystemColors.Control;
            this.exp.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exp.Location = new System.Drawing.Point(295, 296);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(50, 50);
            this.exp.TabIndex = 50;
            this.exp.Text = "Exp";
            this.exp.UseVisualStyleBackColor = true;
            this.exp.Click += new System.EventHandler(this.exp_Click_1);
            // 
            // sqrt
            // 
            this.sqrt.BackColor = System.Drawing.SystemColors.Control;
            this.sqrt.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqrt.Location = new System.Drawing.Point(295, 240);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(50, 50);
            this.sqrt.TabIndex = 49;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click_1);
            // 
            // squart
            // 
            this.squart.BackColor = System.Drawing.SystemColors.Control;
            this.squart.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.squart.Location = new System.Drawing.Point(295, 128);
            this.squart.Name = "squart";
            this.squart.Size = new System.Drawing.Size(50, 50);
            this.squart.TabIndex = 48;
            this.squart.Text = "X^2";
            this.squart.UseVisualStyleBackColor = true;
            this.squart.Click += new System.EventHandler(this.squart_Click);
            // 
            // ctg
            // 
            this.ctg.BackColor = System.Drawing.SystemColors.Control;
            this.ctg.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ctg.Location = new System.Drawing.Point(239, 296);
            this.ctg.Name = "ctg";
            this.ctg.Size = new System.Drawing.Size(50, 50);
            this.ctg.TabIndex = 47;
            this.ctg.Text = "ctg";
            this.ctg.UseVisualStyleBackColor = true;
            this.ctg.Click += new System.EventHandler(this.ctg_Click_1);
            // 
            // tg
            // 
            this.tg.BackColor = System.Drawing.SystemColors.Control;
            this.tg.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tg.Location = new System.Drawing.Point(239, 240);
            this.tg.Name = "tg";
            this.tg.Size = new System.Drawing.Size(50, 50);
            this.tg.TabIndex = 46;
            this.tg.Text = "tg";
            this.tg.UseVisualStyleBackColor = true;
            this.tg.Click += new System.EventHandler(this.tg_Click_1);
            // 
            // cos
            // 
            this.cos.BackColor = System.Drawing.SystemColors.Control;
            this.cos.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cos.Location = new System.Drawing.Point(239, 184);
            this.cos.Name = "cos";
            this.cos.Size = new System.Drawing.Size(50, 50);
            this.cos.TabIndex = 45;
            this.cos.Text = "cos";
            this.cos.UseVisualStyleBackColor = true;
            this.cos.Click += new System.EventHandler(this.cos_Click_1);
            // 
            // sin
            // 
            this.sin.BackColor = System.Drawing.SystemColors.Control;
            this.sin.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sin.Location = new System.Drawing.Point(239, 128);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(50, 50);
            this.sin.TabIndex = 44;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.sin_Click);
            // 
            // enter
            // 
            this.enter.BackColor = System.Drawing.SystemColors.Control;
            this.enter.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enter.Location = new System.Drawing.Point(183, 296);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(50, 50);
            this.enter.TabIndex = 43;
            this.enter.Text = "=";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click_1);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.SystemColors.Control;
            this.zero.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(127, 296);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(50, 50);
            this.zero.TabIndex = 42;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click_1);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Control;
            this.clear.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear.Location = new System.Drawing.Point(71, 296);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(50, 50);
            this.clear.TabIndex = 41;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // division
            // 
            this.division.BackColor = System.Drawing.SystemColors.Control;
            this.division.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.division.Location = new System.Drawing.Point(15, 296);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(50, 50);
            this.division.TabIndex = 40;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click_1);
            // 
            // multiplication
            // 
            this.multiplication.BackColor = System.Drawing.SystemColors.Control;
            this.multiplication.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multiplication.Location = new System.Drawing.Point(14, 240);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(50, 50);
            this.multiplication.TabIndex = 39;
            this.multiplication.Text = "*";
            this.multiplication.UseVisualStyleBackColor = true;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click_1);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.SystemColors.Control;
            this.minus.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(14, 184);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(50, 50);
            this.minus.TabIndex = 38;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click_1);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.SystemColors.Control;
            this.plus.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(14, 128);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(50, 50);
            this.plus.TabIndex = 37;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click_1);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.SystemColors.Control;
            this.eight.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eight.Location = new System.Drawing.Point(127, 240);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(50, 50);
            this.eight.TabIndex = 36;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click_1);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.SystemColors.Control;
            this.seven.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seven.Location = new System.Drawing.Point(71, 240);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(50, 50);
            this.seven.TabIndex = 35;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click_1);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.SystemColors.Control;
            this.six.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.six.Location = new System.Drawing.Point(183, 184);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(50, 50);
            this.six.TabIndex = 34;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click_1);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.SystemColors.Control;
            this.nine.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nine.Location = new System.Drawing.Point(183, 240);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(50, 50);
            this.nine.TabIndex = 33;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click_1);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.SystemColors.Control;
            this.five.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.five.Location = new System.Drawing.Point(127, 184);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(50, 50);
            this.five.TabIndex = 32;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click_1);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.SystemColors.Control;
            this.four.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.four.Location = new System.Drawing.Point(71, 184);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(50, 50);
            this.four.TabIndex = 31;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click_1);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.SystemColors.Control;
            this.three.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.three.Location = new System.Drawing.Point(183, 128);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(50, 50);
            this.three.TabIndex = 30;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click_1);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.SystemColors.Control;
            this.two.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.two.Location = new System.Drawing.Point(127, 128);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(50, 50);
            this.two.TabIndex = 29;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click_1);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.SystemColors.Control;
            this.one.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(71, 128);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(50, 50);
            this.one.TabIndex = 28;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(14, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(331, 76);
            this.textBox1.TabIndex = 27;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-4, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(373, 440);
            this.tabControl1.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 303);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 36);
            this.textBox4.TabIndex = 19;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(250, 303);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 36);
            this.textBox5.TabIndex = 20;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 437);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button hex;
        private System.Windows.Forms.Button bin;
        private System.Windows.Forms.Button oct;
        private System.Windows.Forms.Button dec;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button squart;
        private System.Windows.Forms.Button ctg;
        private System.Windows.Forms.Button tg;
        private System.Windows.Forms.Button cos;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label znak;
        private System.Windows.Forms.Label stroka;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button checksim;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label metr;
        private System.Windows.Forms.Button V;
        private System.Windows.Forms.ComboBox CB2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kolvo;
        private System.Windows.Forms.ComboBox CB1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

