public class Solution {
    public bool IsValidSudoku(char[][] board) {

        for(int row = 0 ; row < 9 ; row ++  ){
            HashSet<char> seen = new();
            for(int column  = 0 ; column < 9 ; column++){
                if(board[row][column]=='.') continue;
                if(seen.Contains(board[row][column])) return false;
                seen.Add(board[row][column]);
            } 
        }

        for ( int column = 0 ; column < 9 ; column++){
            HashSet<char> seen = new();

            for(int row = 0; row < 9 ; row++){
                if(board[row][column]=='.') continue;
                if(seen.Contains(board[row][column])) return false;
                seen.Add(board[row][column]);

            }

        }

        for(int square = 0 ; square < 9 ; square++){
            HashSet<char> seen = new();

            for(int i = 0 ; i < 3 ; i++){

                int row  = (square / 3) * 3 +  i;
                for(int j = 0 ; j < 3 ; j++){
                    int column =(square % 3) * 3 + j;
                    if(board[row][column]== '.')continue;
                    if(seen.Contains(board[row][column])) return false;

                    seen.Add(board[row][column]);
                }

            }

        }

        return true;


        
    


    }
}
