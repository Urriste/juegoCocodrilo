using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using trabajoPractico3.Properties;

namespace trabajoPractico3
{
    public partial class frmCocodrilo : Form
    {
        public frmCocodrilo()
        {
            InitializeComponent();
        }

        Random randomGenerator = new Random();
        Int32 firstNumber = 0;
        Int32 secondNumber = 0;
        Int32 successes = 0;
        Int32 failures = 0;

        private void btnJugar_Click(object sender, EventArgs e)
        {
           
            showOptionsAndHidePlayButtons();
            resetImages();
            handleFirstNumber();
            handleSecondNumber();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            pbxEleccion.Image = trabajoPractico3.Properties.Resources.Menor;
            showPlayButtonAndHideOptions();
            if (firstNumber < secondNumber)
            {
                handleSuccess();
            }
            else
            {
                handleError();
            }
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
         
            pbxEleccion.Image = trabajoPractico3.Properties.Resources.Mayor;
            showPlayButtonAndHideOptions();
            if (firstNumber > secondNumber)
            {
                handleSuccess();
            }
            else
            {
                handleError();
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            pbxEleccion.Image = trabajoPractico3.Properties.Resources.Igual;
            showPlayButtonAndHideOptions(); 
            if (firstNumber == secondNumber)
            {
                handleSuccess();
            }
            else
            {
                handleError();
            }
        }



        private void handleFirstNumber()
        {
            firstNumber = (Int32)randomGenerator.Next(0, 10);

            switch (firstNumber)
            {

                case 0:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._0;
                    break;
                case 1:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._1;
                    break;
                case 2:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._2;
                    break;
                case 3:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._3;
                    break;
                case 4:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._4;
                    break;
                case 5:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._5;
                    break;
                case 6:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._6;
                    break;
                case 7:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._7;
                    break;
                case 8:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._8;
                    break;
                case 9:
                    pbxPrimerNumero.Image = trabajoPractico3.Properties.Resources._9;
                    break;

            }
        }

        private void handleSecondNumber()
        {
            secondNumber = (Int32)randomGenerator.Next(0, 10);

            switch (secondNumber)
            {
                case 0:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._0;
                    break;
                case 1:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._1;
                    break;
                case 2:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._2;
                    break;
                case 3:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._3;
                    break;
                case 4:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._4;
                    break;
                case 5:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._5;
                    break;
                case 6:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._6;
                    break;
                case 7:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._7;
                    break;
                case 8:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._8;
                    break;
                case 9:
                    pbxSegundoNumero.Image = trabajoPractico3.Properties.Resources._9;
                    break;

            }
        }

        private void showOptionsAndHidePlayButtons() {
            btnMayor.Visible = true;
            btnMenor.Visible = true;
            btnIgual.Visible = true;
            btnJugar.Visible = false;
            btnVolverAJugar.Visible = false;
        }

        private void showPlayButtonAndHideOptions()
        {
            btnMayor.Visible = false;
            btnMenor.Visible = false;
            btnIgual.Visible = false;
            btnJugar.Visible = true;
        }

        private void gameFinished()
        {
            btnMayor.Visible = false;
            btnMenor.Visible = false;
            btnIgual.Visible = false;
            btnJugar.Visible = false;
            btnVolverAJugar.Visible = true;
            pbxEleccion.Visible = false;
            pbxPrimerNumero.Visible = false;
            pbxSegundoNumero.Visible = false;
            pbxResultado.Visible = false;

            pbxResultadoFinal.Visible = true;
            lblTextoFinal.Visible = true;

            resetScoresAndNumbers();
        }

        private void resetImages()
        {
            pbxEleccion.Image = null;
            pbxPrimerNumero.Image = null;
            pbxSegundoNumero.Image = null;
            pbxResultado.Image = null;
        }

        private void resetScoresAndNumbers()
        {
            firstNumber = 0;
            secondNumber = 0;
            secondNumber = 0;
            successes = 0;
            failures = 0;
            lblAciertos.Text = "Aciertos: " + successes.ToString();
            lblErrores.Text = "Errores: " + failures.ToString();
        }

        private void handleSuccess() {
            pbxResultado.Image = trabajoPractico3.Properties.Resources.Bien;
            successes = successes + 2;
            lblAciertos.Text = "Aciertos: " + successes.ToString();
            if(successes > 10)
            {
                gameFinished();
                pbxResultadoFinal.Image = trabajoPractico3.Properties.Resources.CocoFeliz;
                lblTextoFinal.Text = "Ganaste";
            }
        }

        private void handleError() {
            pbxResultado.Image = trabajoPractico3.Properties.Resources.Mal;
            successes = successes - 1;
            failures++;
            lblAciertos.Text = "Aciertos: " + successes.ToString();
            lblErrores.Text = "Errores: " + failures.ToString();

            if(successes < 0)
            {
                gameFinished();
                pbxResultadoFinal.Image = trabajoPractico3.Properties.Resources.CocoTriste;
                lblTextoFinal.Text = "Perdiste";
            }
        }

        private void btnVolverAJugar_Click(object sender, EventArgs e)
        {
            resetImages();
            showOptionsAndHidePlayButtons();
            handleFirstNumber();
            handleSecondNumber();
            pbxEleccion.Visible = true;
            pbxPrimerNumero.Visible = true;
            pbxSegundoNumero.Visible = true;
            pbxResultado.Visible = true;

            pbxResultadoFinal.Visible = false;
            lblTextoFinal.Visible = false;
        }

      
    }
}
