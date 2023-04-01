using System;

class ProgramSaver
{

    public void SaveData(List<SchoolClass> classes)
    {
        List<string> data = new List<string>();
        foreach (SchoolClass g in classes)
        {
            data.AddRange(g.saveClass());
        }

        using (StreamWriter outputFile = new StreamWriter("classes.txt"))
        {
            foreach (string s in data)
            {
                outputFile.WriteLine(s);
            }
        }
    }
    public void SaveProfile(Profile user)
    {
        user.savedata();
    }
}