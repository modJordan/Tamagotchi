let frameIndex = 0;
const totalFrames = 4; // The total number of frames in your sprite sheet

setInterval(function() {
  const xPosition = -(frameIndex * 15); // 100 is the width of one frame
  document.getElementById('sprite').style.backgroundPosition = xPosition + 'px 0';

  frameIndex = (frameIndex + 1) % totalFrames; // Reset after the last frame
}, 100); // 100 milliseconds for each frame
