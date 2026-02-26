namespace Shooter.Scene;

public class GameScene : Scene
{
    public GameScene() : base()
    {
        
    }

    public override void Initialize()
    {
        base.Initialize();
    }

    public override void LoadContent()
    {
        base.LoadContent();
    }

    public override void Update(GameTime gameTime)
    {
        base.Update(gameTime);
    }

    public override void Draw(GameTime gameTime)
    {
        Core.GraphicsDevice.Clear(Color.Black);
        Core.SpriteBatch.Begin(samplerState: SamplerState.PointClamp);

        base.Draw(gameTime);

        Core.SpriteBatch.End();
    }
}