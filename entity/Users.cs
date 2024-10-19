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
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAuthService.entity
{

    public class Users
    {
        [Key]
        [DatabaseGenerated((DatabaseGeneratedOption.Identity))]
        public long Id { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string Username { get; set; } = null!;
        
        [Required]
        [MaxLength(20)]
        public string Password { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        public string Email { get; set; } = null!;
        
        [Required]
        [MaxLength(5)]
        public string Roles { get; set; } = null!;
        
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}