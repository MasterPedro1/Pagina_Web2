import { Game } from './geodash.js';

const config = {
  type: Phaser.AUTO,
  width: 800,
  height: 500,
  scene: [Game],
  physics: {
    default: 'arcade',
    arcade: {
      gravity: { y: 800 },
      debug: false
    }
  }
}
var moveCam = false;
var game = new Phaser.Game(config);