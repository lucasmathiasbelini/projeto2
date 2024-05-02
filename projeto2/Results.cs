namespace Projeto2
{
    public class Results
    {
        
        public string sunrise {get; set;} 
        public string sunset {get; set;} 
        public string date {get; set;} 
        public string time {get; set;} 
        public string description {get; set;} 
        public string currently {get; set;} 
        public string city {get; set;} 
        public string humidity {get; set;} 
        public string windCardinal {get; set;} 
        public string moonPhase {get; set;} 

        public int image_id {get; set;} 
        public int temp {get; set;} 

        public float cloudness {get; set;} 
        public float rain {get; set;} 
        public float windSpeedy {get; set;} 

       
        public double condition_code {get; set;} 
        
        
        public Results()
        {
          
        }
    }
}
