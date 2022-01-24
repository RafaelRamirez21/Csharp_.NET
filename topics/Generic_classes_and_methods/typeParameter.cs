public class Pair<TFirst, TSecond>
{
    public TFirst First { get; }
    public TSecond Second { get; }
    
    public Pair(TFirst first, TSecond second) => 
        (First, Second) = (first, second);
}

// var pair = new Pair<int, string>(1, "two");
// int i = pair.First;     //TFirst int
// string s = pair.Second; //TSecond string