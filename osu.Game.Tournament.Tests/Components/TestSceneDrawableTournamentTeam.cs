// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.Bindables;
using osu.Framework.Graphics;
using osu.Game.Tests.Visual;
using osu.Game.Tournament.Components;
using osu.Game.Tournament.Models;
using osu.Game.Tournament.Screens.Drawings.Components;
using osu.Game.Tournament.Screens.Gameplay.Components;
using osu.Game.Tournament.Screens.Ladder.Components;

namespace osu.Game.Tournament.Tests.Components
{
    public class TestSceneDrawableTournamentTeam : OsuGridTestScene
    {
        public TestSceneDrawableTournamentTeam()
            : base(4, 3)
        {
            var team = new TournamentTeam
            {
                FlagName = { Value = "AU" },
                FullName = { Value = "Australia" },
                Players =
                {
                    new TournamentPlayer { Username = "ASecretBox" },
                    new TournamentPlayer { Username = "Dereban" },
                    new TournamentPlayer { Username = "mReKk" },
                    new TournamentPlayer { Username = "uyghti" },
                    new TournamentPlayer { Username = "Parkes" },
                    new TournamentPlayer { Username = "Shiroha" },
                    new TournamentPlayer { Username = "Jordan The Bear" },
                }
            };

            var match = new TournamentMatch { Team1 = { Value = team } };

            int i = 0;

            Cell(i++).AddRange(new Drawable[]
            {
                new TournamentSpriteText { Text = "DrawableTeamFlag" },
                new DrawableTeamFlag(team)
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                }
            });

            Cell(i++).AddRange(new Drawable[]
            {
                new TournamentSpriteText { Text = "DrawableTeamTitle" },
                new DrawableTeamTitle(team)
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                }
            });

            Cell(i++).AddRange(new Drawable[]
            {
                new TournamentSpriteText { Text = "DrawableTeamTitleWithHeader" },
                new DrawableTeamTitleWithHeader(team, TeamColour.Red)
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                }
            });

            Cell(i++).AddRange(new Drawable[]
            {
                new TournamentSpriteText { Text = "DrawableMatchTeam" },
                new DrawableMatchTeam(team, match, false)
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                }
            });

            Cell(i++).AddRange(new Drawable[]
            {
                new TournamentSpriteText { Text = "TeamWithPlayers" },
                new DrawableTeamWithPlayers(team, TeamColour.Blue)
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                }
            });

            Cell(i++).AddRange(new Drawable[]
            {
                new TournamentSpriteText { Text = "GroupTeam" },
                new GroupTeam(team)
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                }
            });

            Cell(i).AddRange(new Drawable[]
            {
                new TournamentSpriteText { Text = "TeamDisplay" },
                new TeamDisplay(team, TeamColour.Red, new Bindable<int?>(2), 6)
                {
                    Anchor = Anchor.Centre,
                    Origin = Anchor.Centre,
                }
            });
        }
    }
}
