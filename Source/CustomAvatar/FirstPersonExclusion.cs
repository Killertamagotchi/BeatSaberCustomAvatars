﻿//  Beat Saber Custom Avatars - Custom player models for body presence in Beat Saber.
//  Copyright © 2018-2020  Beat Saber Custom Avatars Contributors
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.

using UnityEngine;

namespace CustomAvatar
{
    public class FirstPersonExclusion : MonoBehaviour
    {
        [HideInInspector] public GameObject[] Exclude;
        public GameObject[] exclude;

        public void Awake()
        {
            if (Exclude != null && Exclude.Length > 0) exclude = Exclude;
        }
    }
}
