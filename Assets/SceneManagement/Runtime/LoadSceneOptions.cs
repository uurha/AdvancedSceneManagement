﻿using System;
using UnityEngine.SceneManagement;

namespace SceneManagement.Runtime
{
    public delegate void SceneLoaderProgressChanged(float value);

    /// <summary>
    /// Loading Scene Options
    /// </summary>
    [Serializable]
    public class LoadSceneOptions
    {
        public LoadSceneMode SceneLoadMode { get; set; } = LoadSceneMode.Additive;
        public UnloadSceneOptions SceneUnloadMode { get; set; } = UnloadSceneOptions.UnloadAllEmbeddedSceneObjects;
        public bool UseIntermediate { get; set; } = true;

        public SceneLoaderProgressChanged ProgressChanged { get; set; } = null;
    }
}