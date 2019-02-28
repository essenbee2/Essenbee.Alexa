﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Essenbee.Alexa.Lib.Request
{
    public class SupportedInterfaces
    {
        [JsonProperty("AudioPlayer")]
        public SupportedInterfacesAudioPlayer AudioPlayer { get; set; }
    }
}
