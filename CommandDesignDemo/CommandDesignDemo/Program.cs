using CommandDesignDemo.Model;

namespace CommandDesignDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Light light = new Light();
            LightOnCommand livingRoomLightOn = new LightOnCommand(light);
            LightOfCommand livingRoomLightOff = new LightOfCommand(light);

            Remote remote = new Remote();
            remote.SetCommand(livingRoomLightOn);
            remote.PressButton();

            remote.SetCommand(livingRoomLightOff);
            remote.PressButton();
        }
    }
}