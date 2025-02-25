#region

using Autofac;

#endregion

namespace ViteCent.Builder.Api;

/// <summary>
///     AutoFacConfig 类用于配置 Autofac 依赖注入容器。
/// </summary>
public class AutoFacConfig : Module
{
    /// <summary>
    ///     重写 Load 方法以注册依赖项。
    /// </summary>
    /// <param name="builder">用于注册依赖项的 ContainerBuilder 对象。</param>
    protected override void Load(ContainerBuilder builder)
    {
        base.Load(builder);
    }
}