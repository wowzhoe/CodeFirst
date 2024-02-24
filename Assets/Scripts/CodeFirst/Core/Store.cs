namespace CodeFirst
{
    /// <summary>
    /// Value class with globall acces for storing app-level data.
    /// (Only data. For logic, use Services)
    /// Use Boxing to bind listeners to stored data:
    /// Main.Store.someFloat.Value = 42f;
    /// Main.Store.someFloat.Bind(s=>Debug.Log(s));
    /// </summary>
    public class Store
    {
        public Box<float> sliderValue = new Box<float>(0);
        public Box<UnityEngine.Color> color = new Box<UnityEngine.Color>(Constants.ColorStart);
    }
}
