using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using WoadEngine;

namespace Shooter;

public class Game1 : Core
{
    public static int ScreenWidth = 1920, ScreenHeight = 1080;
    public Game1() : base("Shooter", ScreenWidth, ScreenHeight, true)
    {
       
    }

    protected override void Initialize()
    {
        base.Initialize();
    }

    protected override void LoadContent()
    {

    }
}
