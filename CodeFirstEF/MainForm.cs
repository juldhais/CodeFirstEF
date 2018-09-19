using CodeFirstEF.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace CodeFirstEF
{
    public partial class MainForm : Form
    {
        private HeroesModel db;

        public MainForm()
        {
            InitializeComponent();

            buttonSaveChanges.Click += buttonSaveChanges_Click;

            db = new HeroesModel();

            InitializeDataCategory();
            InitializeDataHero();

            db.Heroes.Load();
            heroBindingSource.DataSource = db.Heroes.Local.ToBindingList();

            db.Categories.Load();
            categoryBindingSource.DataSource = db.Categories.Local.ToBindingList();
        }

        private void InitializeDataCategory()
        {
            if (!db.Categories.Any())
            {
                var category1 = new Category();
                category1.Name = "Strengh";
                db.Categories.Add(category1);

                var category2 = new Category();
                category2.Name = "Agility";
                db.Categories.Add(category2);

                var category3 = new Category();
                category3.Name = "Intelligence";
                db.Categories.Add(category3);

                db.SaveChanges();
            }
        }

        private void InitializeDataHero()
        {
            if (!db.Heroes.Any())
            {
                var hero1 = new Hero();
                hero1.Name = "Viper";
                hero1.Category = db.Categories.FirstOrDefault(x => x.Name == "Agility");
                hero1.Attack = 60;
                hero1.Defense = 40;
                db.Heroes.Add(hero1);

                var hero2 = new Hero();
                hero2.Name = "Axe";
                hero2.Category = db.Categories.FirstOrDefault(x => x.Name == "Strengh");
                hero2.Attack = 40;
                hero2.Defense = 60;
                db.Heroes.Add(hero2);

                var hero3 = new Hero();
                hero3.Name = "Lina";
                hero3.Category = db.Categories.FirstOrDefault(x => x.Name == "Intelligence");
                hero3.Attack = 70;
                hero3.Defense = 30;
                db.Heroes.Add(hero3);

                db.SaveChanges();
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }
    }
}
