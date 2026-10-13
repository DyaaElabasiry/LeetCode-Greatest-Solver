public class BusBooking {
    private int rows ;
    private  int[,] busSeats;
    private int booked = 0;
    private int totalTime = 0;

    public BusBooking(int n) {
        rows = n;
        busSeats = new int[n,4];
    }
    
    public void Toggle(string seat) {
        int row = int.Parse(seat.AsSpan(1))-1;
        if (seat[0] == 'A')
        {
            if (busSeats[row,0] != 0)
            {
                totalTime -= busSeats[row,0] ;
                booked--;
                busSeats[row,0]=0;
            }
            else
            {
                if (busSeats[row,1] == 1)
                {
                    busSeats[row,0]=3;
                    totalTime += 3;
                    booked++;
                }
                else
                {
                    busSeats[row,0]=1;
                    totalTime += 1;
                    booked++;
                }
            }
        }else if(seat[0] == 'D')
        {
            if (busSeats[row,3] != 0)
            {
                totalTime -= busSeats[row,3] ;
                booked--;
                busSeats[row,3]=0;
            }
            else
            {
                if (busSeats[row,2] == 1)
                {
                    busSeats[row,3]=3;
                    totalTime += 3;
                    booked++;
                }
                else
                {
                    busSeats[row,3]=1;
                    totalTime += 1;
                    booked++;
                }
            }
        }else if(seat[0] == 'B')
        {
            if (busSeats[row,1] != 0)
            {
                totalTime -- ;
                booked--;
                busSeats[row,1]=0;
            }
            else
            {
                totalTime ++ ;
                booked++;
                busSeats[row,1]=1;
            }
        }else if(seat[0] == 'C')
        {
            if (busSeats[row,2] != 0)
            {
                totalTime -- ;
                booked--;
                busSeats[row,2]=0;
            }
            else
            {
                totalTime ++ ;
                booked++;
                busSeats[row,2]=1;
            }
        }
    }
    
    public int GetTotalTime() {
        
        return totalTime;
    }
    
    public int GetMinTime() {
        return booked;
    }
}
