using CodeChallenge.Domain.Abstract;

namespace CodeChallenge.Domain.Entities
{
    public class Data : IData
    {
        public string Text { get; set; }

        string IData.GetData()
        {
            throw new System.NotImplementedException();
        }
    }
}
