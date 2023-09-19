let frameIndex = 0;
const totalFrames = 14; // The total number of frames in your sprite sheet
const frameHeight = 15;

// Function to update the sprite frame
function updateSprite() {
  console.log('updateSprite called')
  // Calculate the background-position
  const newPosition = -(frameIndex * frameHeight) + 'px';
  console.log(newPosition);


  // Update the background-position
  document.getElementById("sprite").style.backgroundPosition = `0px ${newPosition}`;

  // Increment the frame index
  frameIndex = (frameIndex + 1) % totalFrames;
}

// Set an interval to update the sprite frame
// setInterval(updateSprite, 500); // Updates every 250 milliseconds

window.addEventListener("load", function () {
  console.log("working");
  setInterval(updateSprite, 500);
  updateSprite();
});


// setInterval(function () {
//   const xPosition = -(frameIndex * 15); // 100 is the width of one frame
//   document.getElementById('sprite').style.backgroundPosition = xPosition + 'px 0';

//   frameIndex = (frameIndex + 1) % totalFrames; // Reset after the last frame
// }, 100); // 100 milliseconds for each frame
