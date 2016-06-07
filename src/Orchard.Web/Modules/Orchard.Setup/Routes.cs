﻿using System.Collections.Generic;
using Orchard.Routes;

namespace Orchard.Setup
{
    public class Routes : IRouteProvider
    {
        public IEnumerable<RouteDescriptor> GetRoutes()
        {
            return new[] {
                new RouteDescriptor {
                    Route = new Route(
                        "Setup",
                        "",
                        defaults: new {
                            area = "Orchard.Setup",
                            controller = "Setup",
                            action = "Index"
                        },
                        constraints: new {
                            area = "Orchard.Setup"
                        })
                }
            };
        }
    }
}