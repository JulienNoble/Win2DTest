# Win2DTest

Testing Win2D canvases inside a React Native UWP context.

## How to run

You're going to need [NodeJS](https://nodejs.org/en/) (LTS is fine), and I highly recommend getting [Yarn](https://yarnpkg.com/lang/en/) too, because this takes a while with NPM (which is included with NodeJS). These commands take care of the React Native part.

```
npm install -g react-native-cli
git clone https://github.com/JulienNoble/Win2DTest.git
cd Win2DTest
yarn install
react-native start
```

You should have a message saying `Loading dependency graph, done.`, which means you're ready to go on. The packager, which is started with the last command, is used to serve assets in development mode.

For the UWP part, open `windows/Win2DTest.sln`, set your target to Debug x64 (or x86) on local computer and launch.

App itself shows nothing, but there are debug outputs from the canvas context inside `Win2DImageView.cs`. Be sure to check Visual Studio's console output to see if it works.
