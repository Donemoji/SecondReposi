using System;


namespace WhatisFunction {
    internal class TicTacToe {
        /**
         * 틱 택 토 게임 
         * 컴퓨터와 사람이 번갈아 가면서 O,X를 둔다 
         * 보드 크기는 3*#
         * 컴퓨터의 룰은 간단하게 
         * 1. 중앙이 비었으면 중앙을 선점 하려고 함 
         * 2. 이후에 빈자리 아무곳이나 적당히 찾아서 둔다. 
         */

        enum TicTacToePlayerType { 
            NONE = 0, PLAYER, COMPUTER
        }

        public static void Main() {


            //Console.WriteLine(TicTacToePlayerType.NONE + ",,," + (int)TicTacToePlayerType.PLAYER+"@@@"+ (int)TicTacToePlayerType.COMPUTER);

            int[,] gameBoard = new int[3, 3];
            int playerX, playerY;
            bool isValidLocation = false;
            bool isPlayerTurn = false;
            bool isGameOver = false; 

            String playerIcon = string.Empty;
            String playerType = string.Empty;   

            while(isGameOver == false) {

                //플레이어 턴 진행 
                isPlayerTurn = true;
                playerType = "[플레이어]"; 

                //{플레이어에게서 봐표를 입력받는다. 
                playerX= 0;
                playerY = 0;
                isValidLocation = false;

                while(true) {
                    
                    //루프 탈출 조건, 제대로된 입력을 받은 경우 탈출
                    if(isValidLocation== true) { break; }
                    
                    //플레이어 턴/ 플레이어에게서 좌표 입력 받음 
                    Console.Write("플레이어 (x) 좌표: "); 
                    int.TryParse(Console.ReadLine(), out playerX );
                    Console.Write("플레이어 (y) 좌표: "); 
                    int.TryParse(Console.ReadLine(), out playerY );

                    //게임보드 지정 좌표가 빈곳인지..
                    if (gameBoard[playerY, playerX].Equals((int)TicTacToePlayerType.NONE)) {
                        gameBoard[playerY, playerX] = (int)TicTacToePlayerType.PLAYER;
                        isValidLocation= true;
                    } else {
                        // 보드가 빈곳이 아닌 경우 
                        Console.WriteLine("해당 좌표는 비어있지 않습니다. 다른 좌표를 입력하시오");
                        isValidLocation= false;

                    }


                }//플레이어의 좌표 입력을 받는 루프
                 //}플레이어에게서 좌표를 입력받는다.


                


                //보드 출력
                for(int y =0; y<= gameBoard.GetUpperBound(0); y++) {
                    Console.WriteLine("---|---|---"); 
                    for(int x =0; x<=gameBoard.GetUpperBound(1); x++) {
                        switch(gameBoard[y,x]) {

                            case (int)TicTacToePlayerType.PLAYER:
                                playerIcon = "O";
                                break;
                            case (int)TicTacToePlayerType.COMPUTER: 
                                playerIcon= "X";
                                break;
                            default:
                                playerIcon = " ";
                                break;

                        }
                        Console.Write(" {0} ", playerIcon);

                        //print separator 
                        if(x == gameBoard.GetUpperBound(1)) {
                            //do nothing
                        } else {
                            Console.Write("|");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("---|---|---");

                //게임이 끝났는지 모드 검사 
                Console.WriteLine(); 
                isGameOver= false;
                for(int y = 0; y <=gameBoard.GetUpperBound(0); y++) {
                    //가로 방향으로 검사 하는 루프 
                    if (gameBoard[y, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[y, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[y, 2].Equals((int)TicTacToePlayerType.PLAYER) ) {

                        isGameOver = true;
                    } else {
                        continue;
                    }
                }

                for(int x = 0; x<=gameBoard.GetUpperBound(1); x++) {

                    //세로 방향으로 검사
                    if (gameBoard[0, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[1, x].Equals((int)TicTacToePlayerType.PLAYER) &&
                        gameBoard[2, x].Equals((int)TicTacToePlayerType.PLAYER)) {

                        isGameOver= true;

                    } else {
                        continue;
                    }
                
                }

                //대각선 방향 검사 
                if (gameBoard[0, 0].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[2, 2].Equals((int)TicTacToePlayerType.PLAYER)){

                    isGameOver= true;

                }

                if (gameBoard[0, 2].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.PLAYER) &&
                    gameBoard[2, 0].Equals((int)TicTacToePlayerType.PLAYER)) {

                    isGameOver = true;

                }
                //게임이 끝났는지 보드 검사 
                if(isGameOver) {
                    break;
                }

                //게임이 끝나지 않은 경우 턴을 교체한다. 
                isPlayerTurn = false;
                playerType = "[컴퓨터]";
                bool isComputerDoing = false;

                Console.WriteLine("{0}의 턴", playerType); 
                //컴퓨터는 간단한 룰 

                // 1. 중앙이 비어 있으면 선점 
                if(isComputerDoing == false) {
                    //컴퓨터가 아직 아무것도 하지 않은 경우 
                    if (gameBoard[1, 1].Equals((int)TicTacToePlayerType.NONE)) {
                        //중앙이 비어있는 경우
                        gameBoard[1,1] = (int)TicTacToePlayerType.COMPUTER; 
                        isComputerDoing= true;
                    } else {
                        //do nothing
                    }
                } else {
                    //do nothing
                }
                
                // 2. 적당히 빈 자리 찾아서 착수

                if(isComputerDoing == false) {
                    for(int y =0; y<= gameBoard.GetUpperBound(0); y++) {
                        //search vertical
                        for(int x =0; x<=gameBoard.GetUpperBound(1); x++) {
                            //search horizontal 
                            if(isComputerDoing == false &&
                                gameBoard[y, x].Equals((int)TicTacToePlayerType.NONE)){
                                //서치한 자리가 비어 있는 경우
                                gameBoard[y, x] = (int)TicTacToePlayerType.COMPUTER; 
                                isComputerDoing= true;
                                break;

                            } else {
                                continue;
                            }

                        }
                    }
                } else {
                    //do nothing
                }

                //컴퓨터의 턴 진행을 보드에 출력한다. 
                for(int y =0; y <= gameBoard.GetUpperBound(0); y++) {
                    Console.WriteLine("---|---|---"); 
                    for(int x = 0; x<=gameBoard.GetUpperBound(1); x++) {

                        switch(gameBoard[y, x]){
                            case (int)TicTacToePlayerType.PLAYER:
                                playerIcon = "O";
                                break;
                            case (int)TicTacToePlayerType.COMPUTER:
                                playerIcon = "X";
                                break;
                            default:
                                playerIcon = " ";
                                break;

                        }
                        Console.Write(" {0} ", playerIcon);
                        if(x == gameBoard.GetUpperBound(1)) {
                            //do nothing
                        } else {
                            Console.Write("|");
                        }

                    }
                    Console.WriteLine();
                }
                Console.WriteLine("---|---|---");



                //게임이 끝났는지 보드 검사 
                Console.WriteLine();
                isGameOver = false; 


                //가로 방향 검사
                for(int y =0; y<= gameBoard.GetUpperBound(0); y++) {
                    if (gameBoard[y, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[y, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[y, 2].Equals((int)TicTacToePlayerType.COMPUTER)) {

                        isGameOver = true;

                    } else {
                        continue; 
                    }

                }
                
                //세로 방향 검사
                for(int x = 0; x<= gameBoard.GetUpperBound(1); x++) {
                    if (gameBoard[0, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[1, x].Equals((int)TicTacToePlayerType.COMPUTER) &&
                        gameBoard[2, x].Equals((int)TicTacToePlayerType.COMPUTER)) {

                        isGameOver = true;

                    } else {
                        continue;
                    }
                }

                //대각선 방향 검사 
                
                if (gameBoard[0, 0].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[2, 2].Equals((int)TicTacToePlayerType.COMPUTER)) {

                    isGameOver = true;

                }

                if (gameBoard[0, 2].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[1, 1].Equals((int)TicTacToePlayerType.COMPUTER) &&
                    gameBoard[2, 0].Equals((int)TicTacToePlayerType.COMPUTER)) {

                    isGameOver = true;

                }

                






            }//틱택토 게임 루프



            //누가 이겼는지 출력 
            Console.WriteLine("{0}의 승리..", playerType);



        }


    }
}
