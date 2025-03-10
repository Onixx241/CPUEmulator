public class computer 
{
    //registers for storing values 
    private Dictionary<string,int> registers = new Dictionary<string, int>();

    public computer() 
    {
        registers.Add("A", 0);
        registers.Add("B", 0);
        registers.Add("C", 0);
        registers.Add("ACC", 0);
        registers.Add("SWP", 0);
    }

    public void Execute(string Instruction) 
    {
        var parts = Instruction.Split(' ');

        switch (parts[0].ToUpper()) 
        {
            //instructions
            //MOV
            //ADD
            //SUB
            //MULT
            //PRINT
            //HCF

            //AND
            //OR
            //XOR

            case "MOV":
                if (this.registers.ContainsKey(parts[1])) 
                {
                    this.registers[parts[1]] = int.Parse(parts[2]);
                } 
                break;

            case "ADD":

                if (this.registers.ContainsKey(parts[1]) && this.registers.ContainsKey(parts[2]) ) 
                {
                    this.registers["ACC"] = this.registers[parts[1]] + this.registers[parts[2]];
                }
                break;
            case "SUB":
                if (this.registers.ContainsKey(parts[1]) && this.registers.ContainsKey(parts[2]))
                {
                    this.registers["ACC"] = this.registers[parts[1]] - this.registers[parts[2]];
                }
                break;
            case "MULT":
                if (this.registers.ContainsKey(parts[1]) && this.registers.ContainsKey(parts[2])) 
                {
                    this.registers["ACC"] = this.registers[parts[1]] * this.registers[parts[2]];
                }
                break;

            case "PRINT":

                if (this.registers.ContainsKey(parts[1]))
                {
                    Console.WriteLine(this.registers[parts[1]]);
                }
                break;

            case "DIV":
                if (this.registers.ContainsKey(parts[1])) 
                {
                    this.registers["ACC"] = this.registers[parts[1]] / this.registers[parts[2]];
                }
                break;

            case "SWP":
                var temp = this.registers["SWP"];
                this.registers["SWP"] = this.registers["ACC"];
                this.registers["ACC"] = temp;
                break;


            case "HCF":
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Invalid Instruction");
                break;
        }
    }
    public void Interpreter() 
    {
        
    }
}

public class Program 
{
    public static void Main() 
    {
        computer comp = new computer();

        comp.Execute("MOV A 10");
        comp.Execute("MOV B 10");
        comp.Execute("MOV A SWP");
        comp.Execute("PRINT A");
    }
}