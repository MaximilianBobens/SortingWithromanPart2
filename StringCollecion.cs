using System.Text;

namespace PartTWOStringSortingWithList;

public class StringCollecion
{ 
    public ISortBehaviour SortAlgo { get; set; }

    public StringCollecion()
    {
        SortAlgo = new BubbleSort();
    }
    public List<string> Names { get; init; }

    public void Read(string filename)
    { 
       string[] namesList = File.ReadAllLines(filename);
       Names.AddRange(namesList);
    }

    public bool IsSorted()
    {
        //Liste durchlaufen mit compare To Schauen ob aufsteigend oder absteigend
        return true;
    }

    public void SaveList(string filename)
    {
        File.WriteAllLines(filename,Names.ToArray());
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        //alle Namen anfügen und retour geben
        foreach (var item in Names)
        {
            sb.Append(item).Append(";");
        }
       
        return sb.ToString();
    }

    public int Search(string name)
    {
        return Names.IndexOf(name);
    }

    public int SearchBinary(string name)
    {
        //überprüfe ob Liste sotiert
        //Implementirer die schneele binäre Suche
        if(IsSorted()){}
        else
        {
            return Search(name);
        }
        return -1;
        
    }
    public void Sort()
    {
        
    }
}