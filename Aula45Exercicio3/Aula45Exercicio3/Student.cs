namespace Aula45Exercicio3
{
    class Student
    {
        public string Name;
        public double Score1, Score2, Score3;

        public double FinalScore()
        {
            return Score1 + Score2 + Score3;
        }

        public string FinalResult()
        {
            double finalScore = FinalScore();

            if(finalScore >= 60.00)
            {
                return "APROVADO";
            }
            else
            {
                double missingPoints = 60 - finalScore;
                return "REPROVADO" +
                    $"\nFALTARAM {missingPoints.ToString("F2")} PONTOS";
            }
        }
    }
}
