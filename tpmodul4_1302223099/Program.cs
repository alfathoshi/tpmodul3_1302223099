using static Program.DoorMachine;
using static Program.KodePos;

public class Program
{
    public class KodePos
    {
        public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja }
        public static string getKodePos(Kelurahan namaKelurahan)
        {
            string[] kodePos = { "40266", "40287", "40267", "40256", "40287", "40286", "40286", "40286", "40272", "40274", "40273" };
            return kodePos[(int)namaKelurahan];
        }
    }

    public class DoorMachine
    {
        public enum DoorState { Terkunci, Terbuka }
        public enum Trigger { BukaPintu, KunciPintu }
        public class Transition
        {
            public DoorState stateAwal;
            public DoorState stateAkhir;
            public Trigger trigger;
            public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }

        Transition[] transisi =
        {
            new Transition(DoorState.Terbuka, DoorState.Terkunci, Trigger.KunciPintu),
            new Transition(DoorState.Terkunci, DoorState.Terbuka, Trigger.BukaPintu),
            new Transition(DoorState.Terbuka, DoorState.Terbuka, Trigger.BukaPintu),
            new Transition(DoorState.Terkunci, DoorState.Terkunci, Trigger.KunciPintu),
        };

        public DoorState currentState = DoorState.Terkunci;
        public DoorState GetNextState(DoorState stateAwal, Trigger trigger)
        {
            DoorState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition transition = transisi[i];
                if (stateAwal == transition.stateAwal && trigger == transition.trigger)
                {
                    stateAkhir = transition.stateAkhir;
                }
            }
            return stateAkhir;
        }

        public void ActiveTrigger(Trigger trigger)
        {
            currentState = GetNextState(currentState, trigger);

            Console.WriteLine("State anda sekarang: " + currentState);

            if (currentState == DoorState.Terkunci)
            {
                Console.WriteLine("Kondisi: Terkunci");
            }
            else
            {
                Console.WriteLine("Kondisi: Pintu tidak terkunci");
            }
        }
    }

    public static void Main(string[] args)
    {
        Kelurahan kelurahan = Kelurahan.Batununggal;
        string kodePos = getKodePos((kelurahan));
        Console.WriteLine("Kode Pos");
        Console.WriteLine("Kelurahan " + kelurahan.ToString() + " memiliki kode pos: " + kodePos);
        Console.WriteLine();

        Console.WriteLine("Door Machine");
        DoorMachine objDoor = new DoorMachine();
        Console.WriteLine("State Awal: " + objDoor.currentState);
        Console.WriteLine();

        objDoor.ActiveTrigger(Trigger.KunciPintu);
        Console.WriteLine();
        objDoor.ActiveTrigger(Trigger.BukaPintu);
    }
}