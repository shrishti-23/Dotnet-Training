/*A smart city has 30 street lights numbered 1 to 30. The power consumption (in watts) for each light is calculated using the formula:
Power = 80 + (Light Number × 5)
For each street light:
If power consumption is greater than 180 W, display "Maintenance Required".
Else if power consumption is between 140 W and 180 W, display "Normal Operation".
Otherwise, display "Energy Efficient".
Also calculate and display:
Total power consumed by all street lights
Average power consumption
Number of lights in each category*/

using System;

class Assignment2
{
    public void shown()
    {
        int totalPower = 0;
        int maintenanceRequired = 0;
        int normalOperation = 0;
        int energyEfficient = 0;

        
        for (int lightNumber = 1; lightNumber <= 30; lightNumber++)
        {
            int power = 80 + (lightNumber * 5);

            Console.Write("Light Number " + lightNumber + 
                          " | Power = " + power + "W : ");

            if (power > 180)
            {
                Console.WriteLine("Maintenance Required");
                maintenanceRequired++;
            }
            else if (power >= 140 && power <= 180)
            {
                Console.WriteLine("Normal Operation");
                normalOperation++;
            }
            else
            {
                Console.WriteLine("Energy Efficient");
                energyEfficient++;
            }

            totalPower += power;
        }

        double averagePower = totalPower / 30.0;

        Console.WriteLine("Total Power Consumed : " + totalPower + " W");
        Console.WriteLine("Average Power Consumption : " + averagePower + " W");
        Console.WriteLine("Maintenance Required Lights : " + maintenanceRequired);
        Console.WriteLine("Normal Operation Lights : " + normalOperation);
        Console.WriteLine("Energy Efficient Lights : " + energyEfficient);
    }

    
        
}