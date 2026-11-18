class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:

        #Verifica filas
        for f in range(9):
            seen = set()
            for c in range(9):
                if board[f][c] == ".":
                    continue
                if board[f][c] in seen:
                    return False
                seen.add(board[f][c])

        #Verifica columnas
        for c in range(9):
            seen = set()
            for f in range(9):
                if board[f][c] == ".":
                    continue
                if board[f][c] in seen:
                    return False
                seen.add(board[f][c])

        for square in range(9):
            seen = set()

            for f in range(3):
                f = square // 3 * 3 + f
                for c in range(3):
                    c = square % 3 * 3  + c
                    if board[f][c] == ".":
                        continue
                    if board[f][c] in seen:
                        return False
                    seen.add(board[f][c])

        return True