var PositionPlugin = {
    
    Hello: function()
    {
        window.alert("Hello, world!");
    },
    HelloString: function(str)
    {
        window.alert(Pointer_stringify(str));
    },
    GetPos: function(posString)
    {
        window.alert(Pointer_stringify(posString));
        document.getElementById("obstacles").innerHTML = Pointer_stringify(posString);
    },
    SetFinishPoint: function(finishPoint)
    {
        document.getElementById("finish").innerHTML = Pointer_stringify(finishPoint);
    }
};

mergeInto(LibraryManager.library, PositionPlugin);