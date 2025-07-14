public class Door
{
     public string color { get; set; }
     public bool lockStatus { get; set; }

     public Door(string color, bool lockStatus)
     {
          this.color = color;
          this.lockStatus = lockStatus;
     }
}