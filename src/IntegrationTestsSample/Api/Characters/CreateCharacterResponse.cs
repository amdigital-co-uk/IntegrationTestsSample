﻿using RPGCombatKata.Data;

namespace RPGCombatKata.Api.Characters
{
    public class CreateCharacterResponse : BaseResponse
    {
        public Character character { get; set; }
    }
}
