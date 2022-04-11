// obavezno [Serialize] iznad imena klase

public static void Snimi(string file, Osoba o)
{
	BinaryFormatter br = new BinaryFormatter();

	try 
	{
		FileStream fs = new FileStream(file, FileMode.Create, FileAcess.Write);
		bf.Serialize(fs, o);
	}
	catch (Exception e) 
	{
		Console.WriteLine(e.Message);
	}
	finally
	{
		fs.Close();
	}
}

public static Osoba Ucitaj(string file) 
{
	BinaryFormatter bf = new BinaryFormatter();
	Osoba osoba = null;

	if (File.Exists(file))
	{
		try 
		{
			FileStream fs = new FileStream(file, FileMode.Open, FileAcess.Read);
			osoba = (Osoba)br.Deserialize(fs);
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		finally 
		{
			fs.Close():
		}
	}
	return osoba;
}
