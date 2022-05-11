export class Game extends Phaser.Scene {

    
    constructor()
    {
        super({ key: 'game'})
        this.moveCam = false;
    }

    
     preload ()
    {
        this.load.image('background', 'Multimedia/Galaxy.png');
        this.load.image('Platform', 'Multimedia/Plataforma2.png');
        this.load.image('Platform2', 'Multimedia/Plataforma.png');
        this.load.image('Platform3', 'Multimedia/chica.png');
        this.load.image('Cube', 'Multimedia/Cube.png');
        this.load.image('trap', 'Multimedia/Trampa2.png')
        
    }

     create ()
    {
        this.add.image(400, 250, 'background');

        this.cameras.main.setBounds(0, 0, 7000 * 1, 176);
        
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
        


        /*this.platforms = this.physics.add.group({
            key: 'Platform',
            repeat: 0,
            setXY: { x: 400, y: 400, stepX: 70 , stepY: 0}
            
        });*/
        
        this.traps = this.physics.add.staticGroup();
        this.traps.create(1150, 280, 'trap');
        this.traps.create(1500, 280, 'trap');
        this.traps.create(2100, 205, 'trap');
        this.traps.create(2450, 205, 'trap');
        this.traps.create(3100, 155, 'trap');
        this.traps.create(3350, 155, 'trap');
        this.traps.create(3600, 155, 'trap');






        this.player = this.physics.add.sprite(300, 150, 'Cube');

        this.physics.add.collider(this.player, this.platforms);
        this.player.setVelocityX(250);//250

        this.cursors = this.input.keyboard.createCursorKeys();

        
        this.cameras.main.startFollow(this.player, true);

        this.physics.add.collider(this.player, this.traps, this.muerte, null, this);
    }

    muerte ()
    {
        this.player = this.physics.add.sprite(300, 150, 'Cube');

    }

    update ()
    {
        const cam = this.cameras.main;

        if (this.cursors.up.isDown && this.player.body.touching.down)
        {
            this.player.setVelocityY(-400);
        }

        
    }
}
