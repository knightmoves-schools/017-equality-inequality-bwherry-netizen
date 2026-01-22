namespace knightmoves;
public class Store
{
    public string PriceCheck(double price) {
        
        if (price == 1.50) {
            return "match";
            
        } else {
            return "";
        }
}
        public int GuessNumber(int guess) {

            if (guess != 25){
                return "not it";
                    
            } else {
                return "";
            }
        }        
}

