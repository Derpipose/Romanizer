namespace Romanizer
{
    public class Romanize
    {
        public int Input { get; set; }
        public string Output = "";

        public string Romanization()
        {   
            if(Input >= 4000 || Input < 0)
            {
                Output = "*error*";
                return Output;
            }


            if (Input >= 1000)
            {
                Input -= 1000;
                Output += "M";
            }
            else if ((Input + 100) >= 1000)
            {
                Input -= 900;
                Output += "CM";
            }


            else if (Input >= 500)
            {
                Input -= 500;
                Output += "D";
            }
            else if ((Input + 100) >= 500)
            {
                Input -= 400;
                Output += "CD";
            }


            else if (Input >= 100)
            {
                Input -= 100;
                Output += "C";
            }
            else if ((Input + 10) >= 100)
            {
                Input -= 90;
                Output += "XC";
            }


            else if (Input >= 50)
            {
                Input -= 50;
                Output += "L";
            }
            else if ((Input + 10) >= 50)
            {
                Input -= 40;
                Output += "XL";
            }
            else if (Input >=10) 
            {
                Input -= 10;
                Output += "X";
            }
            else if ((Input + 1) == 10)
            {
                Input -= 9;
                Output += "IX";
            }
            else if (Input >= 5)
            {
                Input -= 5;
                Output += "V";
            }
            else if ((Input + 1) == 5)
            {
                Input -= 4;
                Output += "IV";
            }
            else if (Input > 0 && Input < 5)
            {
                Output += "I";
                Input -= 1;
            }


            if (Input != 0)
            {
                Romanization();
            }
            
            return Output;
        }
    }
}