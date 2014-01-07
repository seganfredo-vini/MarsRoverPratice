using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        private int plateauRoverPositionX;
        private int plateauRoverPositionY;
        private String direction;
        private Plateau plateau;

        public int PlateauX
        {
            get { return plateauRoverPositionX; }
        }
        public int PlateauY
        {
            get { return plateauRoverPositionY; }
        }
        public String Direction
        {
            get { return direction; }
        }

        public Rover(int x, int y, String direction, Plateau plateau)
        {
            if (x >= 0 && y >= 0 && x <= plateau.X && y <= plateau.Y)
            {
                this.plateauRoverPositionX = x;
                this.plateauRoverPositionY = y;
            }
            else
            {
                throw new OutOfBoundsException("Valores negativos não permitidos");
            }
            if (direction.Equals("N") || direction.Equals("S") ||
                direction.Equals("E") || direction.Equals("W"))
            {
                this.direction = direction;
            }
            else
            {
                throw new InvalidStringValueException("String vazia ou inválida.");
            }
            this.plateau = plateau;
        }


        public String ReadCommands(String commands)
        {
            foreach(char character in commands)
            {
                switch (character)
                {
                    case 'L':
                        turn90DegreesToLeft();
                        break;
                    case 'R':
                        turn90DegreesToRight();
                        break;
                    case 'M':
                        moveRover();
                        break;
                }
            }
            return direction;
        }

        public void moveRover()
        {
            switch (direction)
            {
                case "N":
                    if (plateauRoverPositionY <= plateau.Y)                    
                      plateauRoverPositionY = plateauRoverPositionY + 1;
                    else
                      throw new OutOfBoundsException();

                    break;
                case "E":
                    if (plateauRoverPositionX <= plateau.X)
                      plateauRoverPositionX = plateauRoverPositionX + 1;
                    else
                      throw new OutOfBoundsException();
                    
                    break;
                case "S":
                    if (plateauRoverPositionY <= plateau.Y)
                        plateauRoverPositionY = plateauRoverPositionY - 1;
                    else
                        throw new OutOfBoundsException();
                    break;
                case "W":
                    if (plateauRoverPositionX <= plateau.X)
                        plateauRoverPositionX = plateauRoverPositionX - 1;
                    else
                        throw new OutOfBoundsException();
                    break;
            }
        }

        public void turn90DegreesToLeft()
        {
            bool flag = false;

            switch (direction)
            {
                case "S":
                    if(flag != true){
                        direction = "W";
                        flag = true;
                    }
                   
                    break;
                case "W":
                    if (flag != true){
                        direction = "N";
                        flag = true;
                    }
                    break;
                case "N":
                    if (flag != true){
                        direction = "E";
                        flag = true;
                    }
                    break;
                case "E":
                    if (flag != true){
                        direction = "S";
                        flag = true;
                    }
                    break;
            }
           
        }

        public void turn90DegreesToRight()
        {


            bool flag = false;
            switch (direction)
            {
                case "S":
                    if (flag != true)
                    {
                        direction = "E";
                        flag = true;
                    }

                    break;
                case "W":
                    if (flag != true)
                    {
                        direction = "S";
                        flag = true;
                    }
                    break;
                case "N":
                    if (flag != true)
                    {
                        direction = "W";
                        flag = true;
                    }
                    break;
                case "E":
                    if (flag != true)
                    {
                        direction = "N";
                        flag = true;
                    }
                    break;
            }

        }

        public String toString()
        {
            return PlateauX + " " + PlateauY + " " + Direction;
        }
    }
}
