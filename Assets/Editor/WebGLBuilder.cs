using UnityEditor;

class WebGLBuilder {
  static void build() {
    string[] scenes = {
      // replace with your scenes
      "Assets/scenes/SampleScene.unity",
    };

    string pathToDeploy = "Build/WebGL/";

    BuildPipeline.BuildPlayer(
      scenes, pathToDeploy, BuildTarget.WebGL, BuildOptions.None);
  }
}
