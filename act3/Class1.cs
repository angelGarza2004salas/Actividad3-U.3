using System;

public class Class1
{
	public Class1()
	{
		// Variables
        private string nombre;
         private int edad;

    // Constructor
    public Form1(string nombre, int edad)
    {
        InitializeComponent();
        this.nombre = nombre;
        this.edad = edad;
        label1.Text =  "Hola, mi nombre es " + this.textBox1.Text + " y tengo " + this.edad + " años.";
    }

    // Métodos
    private void button1_Click(object sender, EventArgs e)
    {
        if (textBox1.Text == "")
        {
            edad++;
            label1.Text = this.textBox1.Text + " alguien ha cumplido años. Ahora tiene " + this.edad + " años.";
        }
        else
        {
            edad++;
            label1.Text = this.textBox1.Text + " ha cumplido años. Ahora tiene " + this.edad + " años.";
        }
    }

    // Destructor
    ~Form1()
    {
        Console.WriteLine("Se ha destruido el objeto Form1.");
    }

    private void Form1_FormClosing(object sender, FormClosingEventArgs e)
    {
        Console.WriteLine("Se ha cerrado el formulario.");
    }
  }
}



