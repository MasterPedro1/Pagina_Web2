export class Game extends Phaser.Scene {

    
    constructor()
    {
        super({ key: 'game'})
        this.moveCam = false;
    }

    
     preload ()
    {
        this.load.image('background', 'Multimedia/Large.png');
        this.load.image('Platform', 'Multimedia/Plataforma2.png');
        this.load.image('Platform2', 'Multimedia/Plataforma.png');
        this.load.image('Platform3', 'Multimedia/chica.png');
        this.load.image('Cube', 'Multimedia/Cube.png');
        this.load.image('trap', 'Multimedia/Trampa.png')
        this.load.image('Erase', 'Multimedia/borrador.jpg')
        
    }

     create ()
    {

       
        this.add.image(3500, 250, 'background');
        this.add.image(9000, 250, 'background');
        this.add.image(12500, 250, 'background');
        

        this.cameras.main.setBounds(0, 0, 10125 * 1, 176);
        
        this.platforms = this.physics.add.staticGroup();
        this.platforms.create(400, 400, 'Platform');
        this.platforms.create(1350, 325, 'Platform');
        this.platforms.create(2300, 250, 'Platform');
        this.platforms.create(3300, 200, 'Platform');
        
        this.platforms.create(3950, 250, 'Platform2');
        this.platforms.create(4250, 350, 'Platform2');

        this.platforms.create(4550, 300, 'Platform3');
        this.platforms.create(4750, 250, 'Platform3');
        this.platforms.create(4950, 200, 'Platform3');

        this.platforms.create(5600, 150, 'Platform');
        this.platforms.create(6550, 250, 'Platform');
        this.platforms.create(7450, 250, 'Platform');

        this.platforms.create(6811.5, 180, 'Platform2');
        this.platforms.create(7228.5, 180, 'Platform2');

        this.platforms.create(8100, 200, 'Platform2');
        this.platforms.create(8400, 300, 'Platform2');

        this.platforms.create(8700, 250, 'Platform3');
        this.platforms.create(8900, 200, 'Platform3');
        this.platforms.create(9050, 250, 'Platform3');

        this.platforms.create(9750, 400, 'Platform');
     
        
        

        

        /*this.platforms = this.physics.add.group({
            key: 'Platform',
            repeat: 0,
            setXY: { x: 400, y: 400, stepX: 70 , stepY: 0}
            
        });*/
        
        this.traps = this.physics.add.staticGroup();

        this.traps.create(1150, 300, 'trap');
        this.traps.create(1500, 300, 'trap');

        this.traps.create(2100, 225, 'trap');
        this.traps.create(2450, 225, 'trap');

        this.traps.create(3100, 175, 'trap');
        this.traps.create(3350, 175, 'trap');

        this.traps.create(3600, 175, 'trap');
        this.traps.create(5400, 125, 'trap');
        this.traps.create(5750, 125, 'trap');

        this.traps.create(7015, 225, 'trap');
        this.traps.create(7035, 225, 'trap');

        this.traps.create(9550, 375, 'trap');
        this.traps.create(9900, 375, 'trap');







        this.player = this.physics.add.sprite(-10, 370, 'Cube');//-10, 370

        

        this.physics.add.collider(this.player, this.platforms);
        this.player.setVelocityX(250);//250

        this.cursors = this.input.keyboard.createCursorKeys();

        
        this.cameras.main.startFollow(this.player, true);

        this.physics.add.collider(this.player, this.traps, this.muerte, null, this);
    }

    muerte ()
    {
        this.registry.destroy(); // destroy registry
        this.events.off(); // disable all active events
        this.scene.restart(); // restart current scene

    }

    update ()
    {
        //const cam = this.cameras.main;

        if (this.cursors.up.isDown && this.player.body.touching.down)
        {
            this.player.setVelocityY(-400);
        }

        if(this.player.y > 500 || this.player.x > 10150)
        {
            this.muerte();
        }

       

    }
}
