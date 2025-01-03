﻿using System;

namespace Paramore.Brighter.RMQ.Tests.TestDoubles;

internal class QuickHandlerFactoryAsync(Func<IHandleRequestsAsync> handlerAction) : IAmAHandlerFactoryAsync
{
    public IHandleRequestsAsync Create(Type handlerType)
    {
        return handlerAction();
    }

    public void Release(IHandleRequestsAsync handler) { }
}
