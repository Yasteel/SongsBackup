<script setup lang="ts">
  import navBar from '../components/nav-bar.vue';
  import { ref } from 'vue'
  
  const imageSrc = ref('/images/landing-page-img.jpg');
</script>

<template>
  <div class="main">
    <navBar />
    <div class="content">
      <div class="text-content">
        <h2>Backup Your Local Music to Spotify with Ease</h2>
        <p>Welcome to our music backup solution! Effortlessly safeguard your cherished local songs by transferring them to a Spotify playlist. Our web app allows you to:</p>
        <ul>
          <li>Select Your Local Files: Easily choose the songs you want to back up from your device.</li>
          <li>Read Metadata: Our app reads available metadata from your local files to identify the tracks.</li>
          <li>Search Spotify: Automatically search for matching songs on Spotify using the extracted metadata.</li>
          <li>Create Playlists: Seamlessly add the found tracks to a Spotify playlist, preserving your music collection online</li>
        </ul>
        <p>Say goodbye to the fear of losing your favorite tunes. Start backing up your local music to Spotify today!</p>
        
        <button class="get-started">get started</button>
      </div>
      <div class="image-content">
      </div>
    </div>
  </div>
</template>

<style>
  :root{
    --background: #141817;
    --text: #fff;
    --sub-text: #adadad;
    --primary: #21D754;
  }
  
  *{
    font-family: Helvetica;
  }
  
  
  html{
    background: var(--background);
  }
  
  .content{
    width: 100%;
    height: 100vh;
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
  }
  
  .text-content, .image-content{
    width: 50%;
    height: 100%;
  }
  
  
  h2, p{
    color: var(--text);
  }
  
  ul li{
    color: var(--sub-text);
  }
  
  .text-content{
    padding: 0 15rem;
  }
  
  .text-content :is(h2){
    margin: 3rem 0;
  }

  .text-content :is(ul){
    padding: 2rem 0;
  }
  
  .text-content ul li{
    margin: 1rem;
  }
    
  .text-content ul li::marker{
    color: var(--primary);
  }
  
  button.get-started{
    background: var(--primary);
    color: #000;
    text-transform: uppercase;
    padding: 1.5rem 3rem;
    margin: 5rem 0;
    border-radius: .5rem;
    cursor: pointer;
  }
  
  .image-content{
    background-image: url('/Images/landing-page-img.jpg');
    background-size: cover;
    background-position: center;
    background-repeat: no-repeat;
  }
  
  .image-content img{
    width: 100%;
    height: 100%;
  }
</style>