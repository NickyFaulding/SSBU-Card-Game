using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComponentProgrammingAssignment
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Heros heros = new Heros();
        private Bosses bosses = new Bosses();
        private Boss currentBoss;
        private Player player1;
        private Player player2;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                StartGame();
            }
            newBossBtn.Click += new EventHandler(SetBoss);
            newPlayerHand.Click += new EventHandler(SetCardsClicker);
            //flipButton.ServerClick += new EventHandler(SetEventText);
        }

        private void SetEventText(object sender, EventArgs e)
        {
            Label7.Text =  "appears...";
        }

        public void StartGame()
        {
            SetCards();
        }
        
        public void SetPlayerHands()
        {
            player1 = new Player(heros);
            player2 = new Player(heros);
            player1.InitialiseHand();
            player2.InitialiseHand();
        }

        public void SetCards()
        {
            SetPlayerHands();
            SetCardLabels();
            SetCardImages();
            SetUpRadioButtons();
            SetPlayerNameLabels();
        }

        public void SetCardLabels()
        {
            Label1.Text = GetInfoForHero(player1.GetHand(0));
            Label2.Text = GetInfoForHero(player1.GetHand(1));
            Label3.Text = GetInfoForHero(player1.GetHand(2));
            Label4.Text = GetInfoForHero(player2.GetHand(0));
            Label5.Text = GetInfoForHero(player2.GetHand(1));
            Label6.Text = GetInfoForHero(player2.GetHand(2));

        }

        public void SetCardImages()
        {
            Image1.ImageUrl = "Images/" + player1.GetHand(0).GetImage();
            Image2.ImageUrl = "Images/" + player1.GetHand(1).GetImage();
            Image3.ImageUrl = "Images/" + player1.GetHand(2).GetImage();
            Image4.ImageUrl = "Images/" + player2.GetHand(0).GetImage();
            Image5.ImageUrl = "Images/" + player2.GetHand(1).GetImage();
            Image6.ImageUrl = "Images/" + player2.GetHand(2).GetImage();
        }

        public string GetInfoForHero(Hero h)
        {
            return  h.GetName() + "<br />" +
            "Attack : " + h.GetAttack() + "<br />" +
            "Defence : " + h.GetDefence() + "<br />" +
            "Speed : " + h.GetSpeed() + "<br />" +
            "Health : " + h.GetHealth() + "<br />";
        }

        public void SetUpRadioButtons()
        {
            RadioButton1.Text = player1.GetHand(0).GetName();
            RadioButton2.Text = player1.GetHand(1).GetName();
            RadioButton3.Text = player1.GetHand(2).GetName();
            RadioButton4.Text = player2.GetHand(0).GetName();
            RadioButton5.Text = player2.GetHand(1).GetName();
            RadioButton6.Text = player2.GetHand(2).GetName();
        }

        public void SetPlayerNameLabels()
        {
            Player1NameLbl.Text = "Player 1 <br > Total Health : " + player1.GetTotalHealth();
            Player2NameLbl.Text = "Player 2 <br > Total Health : " + player2.GetTotalHealth();
        }

        public void SetBoss(Object sender, EventArgs e)
        {
            currentBoss = bosses.DrawRandomBoss();
            BossImage.ImageUrl = "Images/" + currentBoss.GetImage();
            Label7.Text = currentBoss.GetName() + " has appeared to fight!";
        }
        public void SetCardsClicker(object sender, EventArgs e) //new hand clicker
        {
            SetCards();            
        }

        public string HeroNameForRadioBtn(Hero h)
        {            
            return h.GetName();
        }
    }
}