using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class MainForm : Form
    {
        private string[] keyboard = new string[10] { "Corsair K95 RGB Platinum", "Apple Magic Keyboard", "Razer BlackWidow Elite",
                                                    "Microsoft Sculpt Ergonomic Keyboard", "Logitech K780", "SteelSeries Apex Pro",
                                                    "Dell KB216", "Ducky One 2 Mini", "Cherry MX Board 6.0", "Sensel Morph"};
        private string[] mouse = new string[10] { "Logitech MX Master 3", "Razer DeathAdder Elite", "Apple Magic Mouse 2",
                                                    "SteelSeries Rival 600", "Microsoft Sculpt Ergonomic Mouse", "Corsair Dark Core RGB Pro SE",
                                                    "Logitech G502 HERO", "Razer Naga Trinity", "Logitech MX Anywhere 3", 
                                                    "Finalmouse Ultralight 2 - Cape Town"};
        private string[] monitor = new string[10] { "Dell UltraSharp U2719D", "ASUS ROG Swift PG279Q", "LG 34GN850-B",
                                                    "Samsung Odyssey G7", "BenQ PD3200U", "Acer Predator XB273K",
                                                    "ViewSonic VP2468", "HP Omen X 25f", "Dell S2721QS", "LG UltraGear 27GL850-B"};

        List<Product> products = new List<Product>();

        List<string> userHistory = new List<string>();

        RecommendationManager recommendationManager = new RecommendationManager();
        public MainForm()
        {
            InitializeComponent();
            LoadForm();
        }

        public void LoadForm()
        {
            for (int i = 0; i < 10; i++)
            {
                Monitor mon = new Monitor(monitor[i]);
                products.Add(mon);

                Keyboard key = new Keyboard(keyboard[i]);
                products.Add(key);

                Mouse mou = new Mouse(mouse[i]);
                products.Add(mou);
            }

            PopularProductsRecommendationPlugin popPlugin = new PopularProductsRecommendationPlugin();

            recommendationManager.AddRecommendationPlugin(popPlugin);

            List<string> recommendations = recommendationManager.GetRecommendations(userHistory, products);

            recomendLabel1.Text = "1. " + recommendations[0];
            recomendLabel2.Text = "2. " + recommendations[1];
            recomendLabel3.Text = "3. " + recommendations[2];

            userRecomendLabel1.Text = "1. " + recommendations[0];
            userRecomendLabel2.Text = "2. " + recommendations[1];
            userRecomendLabel3.Text = "3. " + recommendations[2];

            recommendationManager.RemoveRecommendationPlugin(popPlugin);

            recommendationManager.AddRecommendationPlugin(new UserHistoryRecommendationPlugin());
        }

        private void buyMonitorButton_Click(object sender, EventArgs e)
        {
            userHistory.Add(monitorComboBox.Text);

            List<string> recommendations = recommendationManager.GetRecommendations(userHistory, products);

            userRecomendLabel1.Text = "1. " + recommendations[0];
            userRecomendLabel2.Text = "2. " + recommendations[1];
            userRecomendLabel3.Text = "3. " + recommendations[2];
        }

        private void buyKeyboardButton_Click(object sender, EventArgs e)
        {
            userHistory.Add(keyboardComboBox.Text);

            List<string> recommendations = recommendationManager.GetRecommendations(userHistory, products);

            userRecomendLabel1.Text = "1. " + recommendations[0];
            userRecomendLabel2.Text = "2. " + recommendations[1];
            userRecomendLabel3.Text = "3. " + recommendations[2];
        }

        private void buyMouseButton_Click(object sender, EventArgs e)
        {
            userHistory.Add(mouseComboBox.Text);

            List<string> recommendations = recommendationManager.GetRecommendations(userHistory, products);

            userRecomendLabel1.Text = "1. " + recommendations[0];
            userRecomendLabel2.Text = "2. " + recommendations[1];
            userRecomendLabel3.Text = "3. " + recommendations[2];
        }
    }
}
