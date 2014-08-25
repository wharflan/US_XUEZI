function comSlider237409() {
    var self = this;
    var g_HostRoot = "";
    var g_TransitionTimeoutRef = null;
    var g_CycleTimeout = 5;
    var g_currFrame = 0;
    var g_fontLoadJsRetries = 0;
    var g_currDate = new Date(); var g_currTime = g_currDate.getTime(); var g_microID = g_currTime + '-' + Math.floor((Math.random() * 1000) + 1);
    var g_InTransition = 0; var g_Navigation = 0; this.getCurrMicroID = function () { return g_microID; }
    this.comSLoadImgInFrame = function (frameid, src) {
        jqCS237409("#comSImg237409_" + frameid + " img").attr("src", src).load(function () {
            if (!this.complete || typeof this.naturalWidth == "undefined" || this.naturalWidth == 0) {
                //broken image
            }
        });
    }
    this.setNavStyle = function (id, background, color, border, type) {
        if (background == "") {
            jqCS237409("#comSNavigation237409_" + id).css("background", "none");
        }
        else {
            jqCS237409("#comSNavigation237409_" + id).css("background", "#" + background);
        }
        jqCS237409("#comSNavigation237409_" + id).css("background", "#" + background);
        jqCS237409("#comSNavigation237409_" + id).css("color", "#" + color);
        jqCS237409("#comSNavigation237409_" + id).css("border", border + "px solid #" + color);
        var margin = (-1) * border;
        jqCS237409("#comSNavigation237409_" + id).css("margin-top", margin + "px");
        jqCS237409("#comSNavigation237409_" + id).css("margin-left", margin + "px");
        if (type == 0) {
            jqCS237409("#comImgBullet237409_" + id).show();
            jqCS237409("#comImgBulletcurr237409_" + id).hide();
        }
        else {
            jqCS237409("#comImgBulletcurr237409_" + id).show();
            jqCS237409("#comImgBullet237409_" + id).hide();
        }
    }
    this.targetClearTimeouts = function () {
        if (g_TransitionTimeoutRef != null) { window.clearTimeout(g_TransitionTimeoutRef); g_TransitionTimeoutRef = null; }
    }
    this.getNextFrame = function () {
        var ret = g_currFrame;
        ret++;
        if (ret == 5) { ret = 0; }
        return ret;
    }
    this.getPrevFrame = function () {
        var ret = g_currFrame;
        ret--;
        if (ret < 0) { ret = (5 - 1); }
        return ret;
    }
    this.stopAll = function () {
        jqCS237409("#comSFrame237409_0").stop(true, true);
        jqCS237409("#comSFrameSek237409_0").stop(true, true);
        jqCS237409("#comSFrame237409_1").stop(true, true);
        jqCS237409("#comSFrameSek237409_1").stop(true, true);
        jqCS237409("#comSFrame237409_2").stop(true, true);
        jqCS237409("#comSFrameSek237409_2").stop(true, true);
        jqCS237409("#comSFrame237409_3").stop(true, true);
        jqCS237409("#comSFrameSek237409_3").stop(true, true);
        jqCS237409("#comSFrame237409_4").stop(true, true);
        jqCS237409("#comSFrameSek237409_4").stop(true, true);
    }
    this.switchFrame = function () {
        g_Navigation = 1;
        var currFrame = g_currFrame;
        g_currFrame = self.getNextFrame();
        self.switchFromToFrame(currFrame, g_currFrame);
    }

    this.switchFramePrev = function () {
        g_Navigation = 0;
        var currFrame = g_currFrame;
        g_currFrame = self.getPrevFrame();
        self.switchFromToFrame(currFrame, g_currFrame);
    }

    this.switchToFrame = function (toFrame) {
        if ((g_InTransition == 1) || (g_currFrame == toFrame)) {
            if (g_currFrame == toFrame) { return false; }
            self.stopAll();
        }
        var currFrame = g_currFrame;
        g_currFrame = toFrame;
        if (currFrame < g_currFrame)
            g_Navigation = 0;
        else
            g_Navigation = 1;
        self.switchFromToFrame(currFrame, g_currFrame);
    }

    this.switchFromToFrame = function (currFrame, toFrame) {
        if (g_InTransition == 1) {
            self.stopAll();
        }
        g_InTransition = 1;
        self.startTransitionTimer();
        jqCS237409("#comSFrameSek237409_" + currFrame + "").css("z-index", 1);
        jqCS237409("#comSFrameSek237409_" + toFrame + "").css("z-index", 2);
        jqCS237409("#comSFrameSek237409_" + toFrame + "").hide().fadeIn(400, function () {
            if (g_microID != objcomSlider237409.getCurrMicroID()) { return false; }; jqCS237409("#comSFrame237409_" + currFrame).hide(); g_InTransition = 0;
        });
        self.setNavStyle(currFrame, '', 'E5E5E5', 1, 0); self.setNavStyle(toFrame, '', 'B7001F', 3, 1); jqCS237409("#comSFrame237409_" + toFrame).show(1, function () { });




    }
    this.startTransitionTimer = function () {
        self.targetClearTimeouts(); g_TransitionTimeoutRef = window.setTimeout(function () { objcomSlider237409.onTransitionTimeout(g_microID) }, g_CycleTimeout * 1000);
    }
    this.onTransitionTimeout = function (microID) {
        if (g_microID != microID) { return false; }
        self.switchFrame();
    }
    this.initFrame = function () {
        g_currFrame = 0;
        self.startTransitionTimer();
        jqCS237409("#comSFrameSek237409_" + g_currFrame + "").hide().fadeIn(400);
        jqCS237409("#comSFrame237409_" + g_currFrame).show(1, function () { if (g_microID != objcomSlider237409.getCurrMicroID()) { return false; }; self.setNavStyle(g_currFrame, '', 'B7001F', 3, 1); });
        return true;
    }

    this.scriptLoaded = function () {
        jqCS237409 = jQuery237409.noConflict(false); jqCS237409("#comslider_in_point_237409").html('<div id="comSWrapper237409_" name="comSWrapper237409_" style="border:0px; width:530px; height:544px; position: relative;"><div id="comSWrapper237409_" name="comSWrapper237409_" style="overflow:hidden; background: none; border:0px; width:530px; height:544px; "><div id="comSFrameWrapper237409_" name="comSFrameWrapper237409_" style="position: absolute; top: 0px; left: 0px;"><div id="comSFrame237409_0" name="comSFrame237409_0" style="position:absolute; top:0px; left:0px; width:530px; height:530px;"><div id="comSFrameSek237409_0" name="comSFrameSek237409_0" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><div id="comSImg237409_0" name="comSImg237409_0" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><img style="border:0px; width:530px; height:530px;"></img></div></div></div><div id="comSFrame237409_1" name="comSFrame237409_1" style="position:absolute; top:0px; left:0px; width:530px; height:530px;"><div id="comSFrameSek237409_1" name="comSFrameSek237409_1" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><div id="comSImg237409_1" name="comSImg237409_1" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><img style="border:0px; width:530px; height:530px;"></img></div></div></div><div id="comSFrame237409_2" name="comSFrame237409_2" style="position:absolute; top:0px; left:0px; width:530px; height:530px;"><div id="comSFrameSek237409_2" name="comSFrameSek237409_2" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><div id="comSImg237409_2" name="comSImg237409_2" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><img style="border:0px; width:530px; height:530px;"></img></div></div></div><div id="comSFrame237409_3" name="comSFrame237409_3" style="position:absolute; top:0px; left:0px; width:530px; height:530px;"><div id="comSFrameSek237409_3" name="comSFrameSek237409_3" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><div id="comSImg237409_3" name="comSImg237409_3" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><img style="border:0px; width:530px; height:530px;"></img></div></div></div><div id="comSFrame237409_4" name="comSFrame237409_4" style="position:absolute; top:0px; left:0px; width:530px; height:530px;"><div id="comSFrameSek237409_4" name="comSFrameSek237409_4" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><div id="comSImg237409_4" name="comSImg237409_4" style="position:absolute; overflow:hidden; top:0px; left:0px; width:530px; height:530px;"><img style="border:0px; width:582px; height:530px;"></img></div></div></div></div><a name="0" style="cursor:pointer; text-decoration:none !important; font-size:40px;" href=""><div id="comSNavigation237409_0" name="comSNavigation237409_0" style="margin-left:-1px; margin-top:-1px; border: 1px solid #E5E5E5; position:absolute; height:50px; width:50px; top:545px; left:105px; z-index: 5; text-align: center; vertical-align:bottom;  color: #E5E5E5;background: #; "><div id="height_workaround" style="font-size:1px;line-height:0;height:50px;">&nbsp;<img style="position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBullet237409_0" name="comImgBullet237409_0" src="comslider237409/imgnav/1405140717268991.jpeg?timstamp=1400045291" /><img style="display: none; position: absolute; position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBulletcurr237409_0" name="comImgBulletcurr237409_0" src="comslider237409/imgnav/1405140717268991.jpeg?timstamp=1400045291" /></div></div></a><script type="text/javascript"> jqCS237409("#comSNavigation237409_0").fadeTo(0,0.8);</script><a name="1" style="cursor:pointer; text-decoration:none !important; font-size:40px;" href=""><div id="comSNavigation237409_1" name="comSNavigation237409_1" style="margin-left:-1px; margin-top:-1px; border: 1px solid #E5E5E5; position:absolute; height:50px; width:50px; top:545px; left:160px; z-index: 5; text-align: center; vertical-align:bottom;  color: #E5E5E5;background: #; "><div id="height_workaround" style="font-size:1px;line-height:0;height:50px;">&nbsp;<img style="position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBullet237409_1" name="comImgBullet237409_1" src="comslider237409/imgnav/1405140717483481.jpeg?timstamp=1400045291" /><img style="display: none; position: absolute; position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBulletcurr237409_1" name="comImgBulletcurr237409_1" src="comslider237409/imgnav/1405140717483481.jpeg?timstamp=1400045291" /></div></div></a><script type="text/javascript"> jqCS237409("#comSNavigation237409_1").fadeTo(0,0.8);</script><a name="2" style="cursor:pointer; text-decoration:none !important; font-size:40px;" href=""><div id="comSNavigation237409_2" name="comSNavigation237409_2" style="margin-left:-1px; margin-top:-1px; border: 1px solid #E5E5E5; position:absolute; height:50px; width:50px; top:545px; left:215px; z-index: 5; text-align: center; vertical-align:bottom;  color: #E5E5E5;background: #; "><div id="height_workaround" style="font-size:1px;line-height:0;height:50px;">&nbsp;<img style="position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBullet237409_2" name="comImgBullet237409_2" src="comslider237409/imgnav/1405140722466121.jpeg?timstamp=1400045291" /><img style="display: none; position: absolute; position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBulletcurr237409_2" name="comImgBulletcurr237409_2" src="comslider237409/imgnav/1405140722466121.jpeg?timstamp=1400045291" /></div></div></a><script type="text/javascript"> jqCS237409("#comSNavigation237409_2").fadeTo(0,0.8);</script><a name="3" style="cursor:pointer; text-decoration:none !important; font-size:40px;" href=""><div id="comSNavigation237409_3" name="comSNavigation237409_3" style="margin-left:-1px; margin-top:-1px; border: 1px solid #E5E5E5; position:absolute; height:50px; width:50px; top:545px; left:270px; z-index: 5; text-align: center; vertical-align:bottom;  color: #E5E5E5;background: #; "><div id="height_workaround" style="font-size:1px;line-height:0;height:50px;">&nbsp;<img style="position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBullet237409_3" name="comImgBullet237409_3" src="comslider237409/imgnav/1405140726085151.jpeg?timstamp=1400045291" /><img style="display: none; position: absolute; position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBulletcurr237409_3" name="comImgBulletcurr237409_3" src="comslider237409/imgnav/1405140726085151.jpeg?timstamp=1400045291" /></div></div></a><script type="text/javascript"> jqCS237409("#comSNavigation237409_3").fadeTo(0,0.8);</script><a name="4" style="cursor:pointer; text-decoration:none !important; font-size:40px;" href=""><div id="comSNavigation237409_4" name="comSNavigation237409_4" style="margin-left:-1px; margin-top:-1px; border: 1px solid #E5E5E5; position:absolute; height:50px; width:50px; top:545px; left:325px; z-index: 5; text-align: center; vertical-align:bottom;  color: #E5E5E5;background: #; "><div id="height_workaround" style="font-size:1px;line-height:0;height:50px;">&nbsp;<img style="position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBullet237409_4" name="comImgBullet237409_4" src="comslider237409/imgnav/1405140726352211.jpeg?timstamp=1400045291" /><img style="display: none; position: absolute; position: absolute; top: 0px; left: 0px; border:0px;" id="comImgBulletcurr237409_4" name="comImgBulletcurr237409_4" src="comslider237409/imgnav/1405140726352211.jpeg?timstamp=1400045291" /></div></div></a><script type="text/javascript"> jqCS237409("#comSNavigation237409_4").fadeTo(0,0.8);</script></div><div id="comSNavigationControl237409__back" name="comSNavigationControl237409__back" style=" cursor: pointer; margin: 0px; margin-left:5px; border: 0px; position:absolute; height:32px; width:32px; top:274px; left:0px; z-index: 6; text-align: center; vertical-align:bottom;  background-color: transparent; "><img class="def" style="position: absolute; top: 0px; left: 0px; border: 0px;" src="comslider237409/imgnavctl/defback.png?1400045278" /><img class="hover" style="position: absolute; top: 0px; left: 0px; display:none; border: 0px;" src="comslider237409/imgnavctl/defbackhover.png?1400045278" /></div><script type="text/javascript"> jqCS237409("#comSNavigationControl237409__back").bind(\'mouseenter\', function() {  jqCS237409(this).css(\'background-color\', \'transparent\'); jqCS237409("#comSNavigationControl237409__back img.hover").show(); jqCS237409("#comSNavigationControl237409__back img.def").hide(); });</script><script type="text/javascript"> jqCS237409("#comSNavigationControl237409__back").bind(\'mouseleave\', function() {  jqCS237409(this).css(\'background-color\', \'transparent\'); jqCS237409("#comSNavigationControl237409__back img.def").show();  jqCS237409("#comSNavigationControl237409__back img.hover").hide(); });</script><script type="text/javascript"> jqCS237409("#comSNavigationControl237409__back").bind(\'click\', function() { objcomSlider237409.switchFramePrev(); });</script><div id="comSNavigationControl237409__forward" name="comSNavigationControl237409__forward" style=" cursor: pointer; margin: 0px; margin-left:-5px; border: 0px; position:absolute; height:32px; width:32px; top:274px; left:495px; z-index: 6; text-align: center; vertical-align:bottom; background-color: transparent; "><img class="def" style="position: absolute; top: 0px; left: 0px; border: 0px;" src="comslider237409/imgnavctl/defforward.png?1400045278" /><img class="hover" style="position: absolute; top: 0px; left: 0px; display:none; border: 0px;" src="comslider237409/imgnavctl/defforwardhover.png?1400045278" /></div><script type="text/javascript"> jqCS237409("#comSNavigationControl237409__forward").bind(\'mouseenter\', function() {  jqCS237409(this).css(\'background-color\', \'transparent\'); jqCS237409("#comSNavigationControl237409__forward img.hover").show(); jqCS237409("#comSNavigationControl237409__forward img.def").hide(); });</script><script type="text/javascript"> jqCS237409("#comSNavigationControl237409__forward").bind(\'mouseleave\', function() {  jqCS237409(this).css(\'background-color\', \'transparent\'); jqCS237409("#comSNavigationControl237409__forward img.def").show();  jqCS237409("#comSNavigationControl237409__forward img.hover").hide(); });</script><script type="text/javascript"> jqCS237409("#comSNavigationControl237409__forward").bind(\'click\', function() { objcomSlider237409.switchFrame(); });</script><script type="text/javascript"> jqCS237409("#comSNavigationControl237409__back").fadeTo(0,0.8);</script><script type="text/javascript"> jqCS237409("#comSNavigationControl237409__forward").fadeTo(0,0.8);</script></div>');
        jqCS237409("#comslider_in_point_237409 a").bind('click', function () { if ((this.name.length > 0) && (isNaN(this.name) == false)) { self.switchToFrame(parseInt(this.name)); return false; } });
        self.comSLoadImgInFrame("0", "comslider237409/img/1405140717268991.jpeg?1400045278");
        jqCS237409("#comSFrame237409_0").hide();
        self.comSLoadImgInFrame("1", "comslider237409/img/1405140717483481.jpeg?1400045278");
        jqCS237409("#comSFrame237409_1").hide();
        self.comSLoadImgInFrame("2", "comslider237409/img/1405140722466121.jpeg?1400045278");
        jqCS237409("#comSFrame237409_2").hide();
        self.comSLoadImgInFrame("3", "comslider237409/img/1405140726085151.jpeg?1400045278");
        jqCS237409("#comSFrame237409_3").hide();
        self.comSLoadImgInFrame("4", "comslider237409/img/1405140726352211.jpeg?1400045278");
        jqCS237409("#comSFrame237409_4").hide();
        jqCS237409("#comSFrame237409_4").hide();
        self.initFrame();

    }
    var g_CSIncludes = new Array();
    var g_CSLoading = false;
    var g_CSCurrIdx = 0;
    this.include = function (src, last) {
        if (src != '') {
            var tmpInclude = Array();
            tmpInclude[0] = src;
            tmpInclude[1] = last;
            //0
            g_CSIncludes[g_CSIncludes.length] = tmpInclude;
        }
        if ((g_CSLoading == false) && (g_CSCurrIdx < g_CSIncludes.length)) {


            var oScript = null;
            if (g_CSIncludes[g_CSCurrIdx][0].split('.').pop() == 'css') {
                oScript = document.createElement('link');
                oScript.href = g_CSIncludes[g_CSCurrIdx][0];
                oScript.type = 'text/css';
                oScript.rel = 'stylesheet';

                oScript.onloadDone = true;
                g_CSLoading = false;
                g_CSCurrIdx++;
                if (g_CSIncludes[g_CSCurrIdx - 1][1] == true)
                    self.scriptLoaded();
                else
                    self.include('', false);
            }
            else {
                oScript = document.createElement('script');
                oScript.src = g_CSIncludes[g_CSCurrIdx][0];
                oScript.type = 'text/javascript';

                //oScript.onload = scriptLoaded;
                oScript.onload = function () {
                    if (!oScript.onloadDone) {
                        oScript.onloadDone = true;
                        g_CSLoading = false;
                        g_CSCurrIdx++;
                        if (g_CSIncludes[g_CSCurrIdx - 1][1] == true)
                            self.scriptLoaded();
                        else
                            self.include('', false);
                    }
                };
                oScript.onreadystatechange = function () {
                    if (("loaded" === oScript.readyState || "complete" === oScript.readyState) && !oScript.onloadDone) {
                        oScript.onloadDone = true;
                        g_CSLoading = false;
                        g_CSCurrIdx++;
                        if (g_CSIncludes[g_CSCurrIdx - 1][1] == true)
                            self.scriptLoaded();
                        else
                            self.include('', false);
                    }
                }

            }
            //
            document.getElementsByTagName("head").item(0).appendChild(oScript);
            //
            g_CSLoading = true;
        }

    }


}
objcomSlider237409 = new comSlider237409();
objcomSlider237409 = new comSlider237409();
objcomSlider237409.include('comslider237409/js/helpers.js', false);
objcomSlider237409 = new comSlider237409();
objcomSlider237409.include('comslider237409/js/helpers.js', false);
objcomSlider237409.include('comslider237409/js/jquery-1.10.1.js', false);
objcomSlider237409 = new comSlider237409();
objcomSlider237409.include('comslider237409/js/helpers.js', false);
objcomSlider237409.include('comslider237409/js/jquery-1.10.1.js', false);
objcomSlider237409.include('comslider237409/js/jquery-ui-1.10.3.effects.js', true);
