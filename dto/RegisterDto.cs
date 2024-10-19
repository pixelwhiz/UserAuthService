/*
 *   _   _                _         _   _     ____                  _
 *  | | | |___  ___ _ __ / \  _   _| |_| |__ / ___|  ___ _ ____   _(_) ___ ___
 *  | | | / __|/ _ \ '__/ _ \| | | | __| '_ \\___ \ / _ \ '__\ \ / / |/ __/ _ \
 *  | |_| \__ \  __/ | / ___ \ |_| | |_| | | |___) |  __/ |   \ V /| | (_|  __/
 *   \___/|___/\___|_|/_/   \_\__,_|\__|_| |_|____/ \___|_|    \_/ |_|\___\___|
 *
 * Copyright (C) 2024 pixelwhiz
 *
 * This software is distributed under "GNU General Public License v3.0".
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License v3.0
 * along with this program. If not, see <https://opensource.org/licenses/GPL-3.0>.
 */

using System.ComponentModel.DataAnnotations;

namespace UserAuthService.dto
{
    public class RegisterDto
    {
        [Required(ErrorMessage = "Username is required!")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Password is required!")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Password must be between 8 and 100 characters")]
        public string Password { get; set; } = null!;

        
        [Required(ErrorMessage = "Email is required!")]
        [EmailAddress(ErrorMessage = "Email should be valid")]
        public string Email { get; set; } = null!;
    }
}
