using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Questions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name, surname;    //testbox
        string likeSpiders, likeScorps; // radiobutton

        List<string> knowSpiders = new List<string> { },  knowScorps = new List<string> { }; //checkbox
        string gender; // domericupdown
       

        int age;   //numericupdown
        string group;    //combobox
        string selfInfo;
        //bool flag;


        List<Results> users = new List<Results> { };

       

        Random rand = new Random();
        

        private void saveAnsw_Click(object sender, EventArgs e)
        {
            name = Name1.Text;
            surname = Surname.Text;
            selfInfo = SelfInfo.Text;

            age = (int)Age.Value;
            

            group = Gr.Text;
            gender = Gen.Text;

            //num += 1;


            if (LikeSpid.Checked) { likeSpiders = LikeSpid.Text; }
            if (DontLikeSpid.Checked) { likeSpiders = DontLikeSpid.Text; }
            if (LikeScorps.Checked) { likeScorps = LikeScorps.Text; }
            if (DontLikeScorps.Checked) { likeScorps = DontLikeScorps.Text; }

            foreach (CheckBox a in groupBox4.Controls)
            {
                if (a.Checked == true) knowSpiders.Add(a.Text);
            }

            foreach (CheckBox a in groupBox3.Controls)
            {
                if (a.Checked == true) knowScorps.Add(a.Text);
            }
            

            
            //SelfInfo.Text = user.name;
            CreateResult();
            ClearForm();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void auto_Click(object sender, EventArgs e) 
        {
            ClearForm();

            //if (knowScorps.Count == 0) button1.Text = "nen";
            string[] names = { "Григорий", "Александр", "Павел", "Николай", "Василий", "Марк", "Наталья", "Мария", "Рената", "Ольга", "Оксана" };
            int indes = rand.Next(0, names.Length);
            name = names[indes];
            Name1.Text = name;

            string[] surnames = { "Наливайко", "Шпельт", "Иваненко", "Петросян", "Марченко", "Вишня", "Холод", "Кравченко", "Фрунзе", "Агапенко" };
            surname = surnames[rand.Next(0, surnames.Length)];
            Surname.Text = surname;

            age = rand.Next(0, Age.TabIndex + 1);
            Age.Value = age;

            if (indes < 7)  gender = "male";
            else gender = "female";
            Gen.Text = gender;

            switch (rand.Next(0, 2))
            {
                case 0:
                    group = rand.Next(1251, 1256).ToString();
                    break;
                case 1:
                    group = rand.Next(1011, 1016).ToString();
                    break;
            }
            Gr.Text = group;

            switch (rand.Next(0, 2))
            {
                case 0:
                    likeSpiders = LikeSpid.Text;
                    LikeSpid.Checked = true;
                    break;
                case 1:
                    likeSpiders = DontLikeSpid.Text;
                    DontLikeSpid.Checked = true;
                    break;
            }

            switch (rand.Next(0, 2))
            {
                case 0:
                    likeScorps = LikeScorps.Text;
                    LikeScorps.Checked = true;
                    break;
                case 1:
                    likeScorps = DontLikeScorps.Text;
                    DontLikeScorps.Checked = true;
                    break;
            }
            string[] adages = { "Не плюй в колодец, пригодится воды напиться", "И скорпион не сделает того, что иной сделает своему родичу.", "Не беречь поросли, не видать и дерева.", "Придет осень, за все спросит.", "Бедняка и на верблюде скорпион ужалит", "Не зима знобит, а весна.", "Злой человек – что скорпион: смотри, укусит вмиг, не по нужде кусает он, а так уж он привык.", "Лови, паук, мух, поколе ноги не ощипаны.", "Запутался, что мизгирь в тенетах.", "Как мизгирь, из себя нитку тянет. ", "де муха ни летала, а к пауку попала.", "Где паук, там и паутина.", "Пища пчелы превращается в мед, а паука — в яд.", "Когда человек падает, то даже паук на стене свидетельствует против него.", "И паук сначала совьет паутину, а потом ловит насекомых.", "Нужда - паук, а заёмщик, что муха.", "Главная » Пословицы о насекомых\r\nПословицы про скорпиона\r\nРубрика: Пословицы о насекомых     \r\n Враждебнее скорпиона\r\n" };
            selfInfo = adages[rand.Next(0, adages.Length)];
            SelfInfo.Text = selfInfo;

            for (int i = 0; i < rand.Next(1, 6); i++)
            {
                switch(rand.Next(0, 4))
                {
                    case 0:
                        if (knowSpiders.Contains(checkBox1.Text) == false)
                        {
                            knowSpiders.Add(checkBox1.Text);
                            checkBox1.Checked = true; 
                            
                        }
                        break;
                    case 1:
                        if (knowSpiders.Contains(checkBox2.Text) == false)
                        {
                            knowSpiders.Add(checkBox2.Text);
                            checkBox2.Checked = true;
                        }
                        break;
                    case 2:
                        if (knowSpiders.Contains(checkBox3.Text) == false)
                        {
                            knowSpiders.Add(checkBox3.Text);
                            checkBox3.Checked = true;
                        }
                        break;
                    case 3:
                        if (knowSpiders.Contains(checkBox4.Text) == false)
                        {
                            knowSpiders.Add(checkBox4.Text);
                            checkBox4.Checked = true;
                        }
                        break;
                }
            }

            for (int i = 0; i < rand.Next(1, 6); i++)
            {
                switch (rand.Next(0, 4))
                {
                    case 0:
                        if (knowScorps.Contains(checkBox7.Text) == false)
                        {
                            knowScorps.Add(checkBox7.Text);
                            checkBox7.Checked = true;
                        }
                        break;
                    case 1:
                        if (knowScorps.Contains(checkBox8.Text) == false)
                        {
                            knowScorps.Add(checkBox8.Text);
                            checkBox8.Checked = true;
                        }
                        break;
                    case 2:
                        if (knowScorps.Contains(checkBox9.Text) == false)
                        {
                            knowScorps.Add(checkBox9.Text);
                            checkBox9.Checked = true;
                        }
                        break;
                    case 3:
                        if (knowScorps.Contains(checkBox10.Text) == false)
                        {
                            knowScorps.Add(checkBox10.Text);
                            checkBox10.Checked = true;
                        }
                        break;
                }
            }
            
            CreateResult();
       


        }

        private void Answers_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = Answers.SelectedIndex;

            //Name1.Text = foundresult.likeSpiders;
            //button1.Text = users.Count().ToString();
            Results foundresult = users[index];


            FillForm(foundresult);


        }

        void FillForm(Results result)
        {
            ClearForm();

            Name1.Text = result.name;
            Surname.Text = result.surname;
            SelfInfo.Text = result.selfInfo;
            Gr.Text = result.group;
            Gen.Text = result.gender;
            Age.Value = result.age;

            if (result.likeSpiders == "да") { LikeSpid.Checked = true; }
            else if (result.likeSpiders == "нет") { DontLikeSpid.Checked = true; }
            else
            {
                LikeSpid.Checked = false;
                DontLikeSpid.Checked = false;
            }

            if (result.likeScorps == "да") { LikeScorps.Checked = true; }
            else if (result.likeScorps == "нет") { DontLikeScorps.Checked = true; }
            else
            {
                LikeScorps.Checked = false;
                DontLikeScorps.Checked = false;
            }

            for (int i = 0; i < result.knowSpiders.Count; i++)
            {
                switch (result.knowSpiders[i])
                {
                    case "черная вдова":
                        checkBox1.Checked = true;
                        break;
                    case "тарантул":
                        checkBox2.Checked = true;
                        break;
                    case "косеножка":
                        checkBox3.Checked = true;
                        break;
                    case "паук-бродяга":
                        checkBox4.Checked = true;
                        break;

                }
            }

            for (int j = 0; j < result.knowScorps.Count; j++)
            {
                switch (result.knowScorps[j])
                {
                    case "императорский":
                        checkBox10.Checked = true;
                        break;
                    case "яванский":
                        checkBox9.Checked = true;
                        break;
                    case "диктатор":
                        checkBox8.Checked = true;
                        break;
                    case "желтый":
                        checkBox7.Checked = true;
                        break;

                }
            }

        }

        private void ClearForm()
        {

            foreach (Control c in Controls)
            {
                foreach (Control a in groupBox3.Controls)
                { if (a is CheckBox cb) cb.Checked = false; }
                foreach (Control a in groupBox4.Controls)
                { if (a is CheckBox cb) cb.Checked = false; }
                foreach (Control a in groupBox1.Controls)
                { if (a is RadioButton rb) rb.Checked = false; }
                foreach (Control a in groupBox5.Controls)
                { if (a is RadioButton rb) rb.Checked = false; }
                if (c is TextBox tb) tb.Clear();
                if (c is RichTextBox rtb) rtb.Clear();
                if (c is DomainUpDown dud) { dud.ResetText(); dud.Text = ""; }
                if (c is NumericUpDown nud) nud.Value = 20;
                if (c is ComboBox cbb) { cbb.SelectedIndex = -1; cbb.Text = ""; }
            }
            knowSpiders.Clear();
            knowScorps.Clear();
            likeScorps = "1";
            likeSpiders = "11";
        }

        private void toFile_Click(object sender, EventArgs e)
        {
            Serialize(users[Answers.SelectedIndex], fileName.Text);

        }

        private void fromFile_Click(object sender, EventArgs e)
        {
            Deserialize(fileName.Text);
        }

        public void CreateResult()
        {
            if ((Gr.Items.Contains(group) == false) || (Gen.Items.Contains(gender) == false)) MessageBox.Show("введено несуществующее значение", "ошибка");
            if (name == "")
            {
                string title = "Ошибка";
                string message = "Вы не ввели имя";
                MessageBox.Show(message, title);
            }
            else
            {
                List<string> knowSpidersCopy = new List<string>();
                foreach (string spid in knowSpiders)
                {
                    knowSpidersCopy.Add(spid);
                }

                List<string> knowScorpsCopy = new List<string>();
                foreach (string scorp in knowScorps)
                {
                    knowScorpsCopy.Add(scorp);
                }

                Results result = new Results(name, surname, likeSpiders, likeScorps, knowSpidersCopy, knowScorpsCopy, gender, age, group, selfInfo);
                users.Add(result);

                 
                //flag = true;
                Answers.Items.Add($"{name}  {surname}");
            }

        }


        public void Deserialize(string filename)
        {
            if (filename == "") MessageBox.Show("Вы не ввели имя файла", "ошибка");
            else
            {
                string StringFromFile = File.ReadAllText(filename + ".txt");
                string[] fields = StringFromFile.Split('\n');
                name = fields[0]; surname = fields[1]; gender = fields[2]; group = fields[3]; age = Convert.ToInt32(fields[4]); likeSpiders = fields[5]; likeScorps = fields[6]; selfInfo = fields[9];

                
                //fromFile.Text = fields[8];
                string[] spiders = fields[7].Split(',');
                string[] scorps = fields[8].Split(',');

                foreach (string spider in spiders)
                {
                    knowSpiders.Add(spider.Trim());
                    SelfInfo.Text += spider;
                }

                foreach (string scorp in scorps)
                {
                    knowScorps.Add(scorp.Trim());
                }

                CreateResult();
            }
        }
        
        internal void Serialize(Results result, string filename)
        {
            if (filename == "") MessageBox.Show("Вы не ввели имя файла", "ошибка");
            else {
                string StringToFile;
                string spiders = "", scorpions = "";
                foreach (string s in result.knowSpiders)
                {
                    spiders += s + ", ";
                }
                foreach (string s in result.knowScorps)
                {
                    scorpions += s + ", ";
                }
                StringToFile = $"{result.name}\n{result.surname}\n{result.gender}\n{result.group}\n{result.age}\n{result.likeSpiders}\n{result.likeScorps}\n{spiders}\n{scorpions}\n{result.selfInfo}";
                File.WriteAllText(filename + ".txt", StringToFile);

                users.Add(result);
                Answers.Items.Add(filename);
            }

        }

    }
}
