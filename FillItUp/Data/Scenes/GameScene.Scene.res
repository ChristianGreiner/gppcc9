<root dataType="Struct" type="Duality.Resources.Scene" id="129723834">
  <assetInfo />
  <globalGravity dataType="Struct" type="Duality.Vector2">
    <X dataType="Float">0</X>
    <Y dataType="Float">33</Y>
  </globalGravity>
  <serializeObj dataType="Array" type="Duality.GameObject[]" id="427169525">
    <item dataType="Struct" type="Duality.GameObject" id="3006806711">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="451676405">
        <_items dataType="Array" type="Duality.Component[]" id="3065847414" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="1072154347">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">3006806711</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">0</Y>
              <Z dataType="Float">-500</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">0</Y>
              <Z dataType="Float">-500</Z>
            </posAbs>
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Camera" id="3544082518">
            <active dataType="Bool">true</active>
            <farZ dataType="Float">10000</farZ>
            <focusDist dataType="Float">500</focusDist>
            <gameobj dataType="ObjectRef">3006806711</gameobj>
            <nearZ dataType="Float">0</nearZ>
            <passes dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="1057924154">
              <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="3760033024" length="4">
                <item dataType="Struct" type="Duality.Components.Camera+Pass" id="1360833180">
                  <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba">
                    <A dataType="Byte">255</A>
                    <B dataType="Byte">245</B>
                    <G dataType="Byte">245</G>
                    <R dataType="Byte">245</R>
                  </clearColor>
                  <clearDepth dataType="Float">1</clearDepth>
                  <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="All" value="3" />
                  <input />
                  <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="PerspectiveWorld" value="0" />
                  <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                  <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="AllGroups" value="2147483647" />
                </item>
                <item dataType="Struct" type="Duality.Components.Camera+Pass" id="457384470">
                  <clearColor dataType="Struct" type="Duality.Drawing.ColorRgba" />
                  <clearDepth dataType="Float">1</clearDepth>
                  <clearFlags dataType="Enum" type="Duality.Drawing.ClearFlag" name="None" value="0" />
                  <input />
                  <matrixMode dataType="Enum" type="Duality.Drawing.RenderMatrix" name="OrthoScreen" value="1" />
                  <output dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.RenderTarget]]" />
                  <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
                </item>
              </_items>
              <_size dataType="Int">2</_size>
              <_version dataType="Int">2</_version>
            </passes>
            <perspective dataType="Enum" type="Duality.Drawing.PerspectiveMode" name="Parallax" value="1" />
            <visibilityMask dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="All" value="4294967295" />
          </item>
          <item dataType="Struct" type="Duality.Components.SoundListener" id="3660288082">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">3006806711</gameobj>
          </item>
        </_items>
        <_size dataType="Int">3</_size>
        <_version dataType="Int">3</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3644564680" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2036083039">
            <item dataType="Type" id="1036162158" value="Duality.Components.Transform" />
            <item dataType="Type" id="49067978" value="Duality.Components.Camera" />
            <item dataType="Type" id="1603834974" value="Duality.Components.SoundListener" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="1258191648">
            <item dataType="ObjectRef">1072154347</item>
            <item dataType="ObjectRef">3544082518</item>
            <item dataType="ObjectRef">3660288082</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">1072154347</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2458200781">CHb3cc86Vky5q/h34X8Y6Q==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">MainCamera</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="3114500229">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3428221431">
        <_items dataType="Array" type="Duality.Component[]" id="4283982478" length="4">
          <item dataType="Struct" type="FillItUp.GameManager" id="378336785">
            <active dataType="Bool">true</active>
            <activeCup dataType="Struct" type="FillItUp.Cup" id="3412224861">
              <active dataType="Bool">true</active>
              <cupLimitSpriteRenderer dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="2255617758">
                <active dataType="Bool">true</active>
                <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                  <A dataType="Byte">163</A>
                  <B dataType="Byte">27</B>
                  <G dataType="Byte">139</G>
                  <R dataType="Byte">224</R>
                </colorTint>
                <customMat />
                <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
                <gameobj dataType="Struct" type="Duality.GameObject" id="613451190">
                  <active dataType="Bool">true</active>
                  <children />
                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="2314605510">
                    <_items dataType="Array" type="Duality.Component[]" id="2804866304" length="4">
                      <item dataType="Struct" type="Duality.Components.Transform" id="2973766122">
                        <active dataType="Bool">true</active>
                        <angle dataType="Float">3.14159274</angle>
                        <angleAbs dataType="Float">3.14159274</angleAbs>
                        <angleVel dataType="Float">0</angleVel>
                        <angleVelAbs dataType="Float">0</angleVelAbs>
                        <deriveAngle dataType="Bool">true</deriveAngle>
                        <gameobj dataType="ObjectRef">613451190</gameobj>
                        <ignoreParent dataType="Bool">false</ignoreParent>
                        <parentTransform dataType="Struct" type="Duality.Components.Transform" id="1758948612">
                          <active dataType="Bool">true</active>
                          <angle dataType="Float">0</angle>
                          <angleAbs dataType="Float">0</angleAbs>
                          <angleVel dataType="Float">0</angleVel>
                          <angleVelAbs dataType="Float">0</angleVelAbs>
                          <deriveAngle dataType="Bool">true</deriveAngle>
                          <gameobj dataType="Struct" type="Duality.GameObject" id="3693600976">
                            <active dataType="Bool">true</active>
                            <children dataType="Struct" type="System.Collections.Generic.List`1[[Duality.GameObject]]" id="980943206">
                              <_items dataType="Array" type="Duality.GameObject[]" id="1601745792" length="4">
                                <item dataType="Struct" type="Duality.GameObject" id="796989925">
                                  <active dataType="Bool">true</active>
                                  <children />
                                  <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="33760849">
                                    <_items dataType="Array" type="Duality.Component[]" id="4288979950" length="4">
                                      <item dataType="Struct" type="Duality.Components.Transform" id="3157304857">
                                        <active dataType="Bool">true</active>
                                        <angle dataType="Float">3.14159274</angle>
                                        <angleAbs dataType="Float">3.14159274</angleAbs>
                                        <angleVel dataType="Float">0</angleVel>
                                        <angleVelAbs dataType="Float">0</angleVelAbs>
                                        <deriveAngle dataType="Bool">true</deriveAngle>
                                        <gameobj dataType="ObjectRef">796989925</gameobj>
                                        <ignoreParent dataType="Bool">false</ignoreParent>
                                        <parentTransform dataType="ObjectRef">1758948612</parentTransform>
                                        <pos dataType="Struct" type="Duality.Vector3">
                                          <X dataType="Float">0</X>
                                          <Y dataType="Float">81</Y>
                                          <Z dataType="Float">0</Z>
                                        </pos>
                                        <posAbs dataType="Struct" type="Duality.Vector3">
                                          <X dataType="Float">0</X>
                                          <Y dataType="Float">81</Y>
                                          <Z dataType="Float">0</Z>
                                        </posAbs>
                                        <scale dataType="Float">1</scale>
                                        <scaleAbs dataType="Float">1</scaleAbs>
                                        <vel dataType="Struct" type="Duality.Vector3" />
                                        <velAbs dataType="Struct" type="Duality.Vector3" />
                                      </item>
                                      <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="2439156493">
                                        <active dataType="Bool">true</active>
                                        <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                                          <A dataType="Byte">255</A>
                                          <B dataType="Byte">189</B>
                                          <G dataType="Byte">165</G>
                                          <R dataType="Byte">21</R>
                                        </colorTint>
                                        <customMat />
                                        <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
                                        <gameobj dataType="ObjectRef">796989925</gameobj>
                                        <offset dataType="Int">0</offset>
                                        <pixelGrid dataType="Bool">false</pixelGrid>
                                        <rect dataType="Struct" type="Duality.Rect">
                                          <H dataType="Float">0</H>
                                          <W dataType="Float">100</W>
                                          <X dataType="Float">-50</X>
                                          <Y dataType="Float">0</Y>
                                        </rect>
                                        <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                                        <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                                          <contentPath dataType="String">Default\Texture\White.Material.res</contentPath>
                                        </sharedMat>
                                        <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                                      </item>
                                    </_items>
                                    <_size dataType="Int">2</_size>
                                    <_version dataType="Int">2</_version>
                                  </compList>
                                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2834896032" surrogate="true">
                                    <header />
                                    <body>
                                      <keys dataType="Array" type="System.Object[]" id="1645275515">
                                        <item dataType="ObjectRef">1036162158</item>
                                        <item dataType="Type" id="4148054" value="Duality.Components.Renderers.SpriteRenderer" />
                                      </keys>
                                      <values dataType="Array" type="System.Object[]" id="2869303464">
                                        <item dataType="ObjectRef">3157304857</item>
                                        <item dataType="ObjectRef">2439156493</item>
                                      </values>
                                    </body>
                                  </compMap>
                                  <compTransform dataType="ObjectRef">3157304857</compTransform>
                                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                                    <header>
                                      <data dataType="Array" type="System.Byte[]" id="3600079985">QFOLrwpe80qwzt6VV1fCVg==</data>
                                    </header>
                                    <body />
                                  </identifier>
                                  <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                                  <name dataType="String">Water</name>
                                  <parent dataType="ObjectRef">3693600976</parent>
                                  <prefabLink />
                                </item>
                                <item dataType="ObjectRef">613451190</item>
                              </_items>
                              <_size dataType="Int">2</_size>
                              <_version dataType="Int">2</_version>
                            </children>
                            <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3094987578">
                              <_items dataType="Array" type="Duality.Component[]" id="88306900" length="4">
                                <item dataType="ObjectRef">1758948612</item>
                                <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="1040800248">
                                  <active dataType="Bool">true</active>
                                  <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
                                    <A dataType="Byte">255</A>
                                    <B dataType="Byte">255</B>
                                    <G dataType="Byte">255</G>
                                    <R dataType="Byte">255</R>
                                  </colorTint>
                                  <customMat />
                                  <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
                                  <gameobj dataType="ObjectRef">3693600976</gameobj>
                                  <offset dataType="Int">0</offset>
                                  <pixelGrid dataType="Bool">false</pixelGrid>
                                  <rect dataType="Struct" type="Duality.Rect">
                                    <H dataType="Float">180</H>
                                    <W dataType="Float">120</W>
                                    <X dataType="Float">-60</X>
                                    <Y dataType="Float">-90</Y>
                                  </rect>
                                  <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                                  <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                                    <contentPath dataType="String">Data\Sprites\cup1.Material.res</contentPath>
                                  </sharedMat>
                                  <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
                                </item>
                                <item dataType="ObjectRef">3412224861</item>
                              </_items>
                              <_size dataType="Int">3</_size>
                              <_version dataType="Int">3</_version>
                            </compList>
                            <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="933978598" surrogate="true">
                              <header />
                              <body>
                                <keys dataType="Array" type="System.Object[]" id="1254281984">
                                  <item dataType="ObjectRef">1036162158</item>
                                  <item dataType="ObjectRef">4148054</item>
                                  <item dataType="Type" id="1468131996" value="FillItUp.Cup" />
                                </keys>
                                <values dataType="Array" type="System.Object[]" id="3333493198">
                                  <item dataType="ObjectRef">1758948612</item>
                                  <item dataType="ObjectRef">1040800248</item>
                                  <item dataType="ObjectRef">3412224861</item>
                                </values>
                              </body>
                            </compMap>
                            <compTransform dataType="ObjectRef">1758948612</compTransform>
                            <identifier dataType="Struct" type="System.Guid" surrogate="true">
                              <header>
                                <data dataType="Array" type="System.Byte[]" id="2709208476">maxSRXXjfUyrlXrvfeJINA==</data>
                              </header>
                              <body />
                            </identifier>
                            <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                            <name dataType="String">Cup</name>
                            <parent />
                            <prefabLink />
                          </gameobj>
                          <ignoreParent dataType="Bool">false</ignoreParent>
                          <parentTransform />
                          <pos dataType="Struct" type="Duality.Vector3" />
                          <posAbs dataType="Struct" type="Duality.Vector3" />
                          <scale dataType="Float">1</scale>
                          <scaleAbs dataType="Float">1</scaleAbs>
                          <vel dataType="Struct" type="Duality.Vector3" />
                          <velAbs dataType="Struct" type="Duality.Vector3" />
                        </parentTransform>
                        <pos dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">4.76837158E-07</X>
                          <Y dataType="Float">65</Y>
                          <Z dataType="Float">0</Z>
                        </pos>
                        <posAbs dataType="Struct" type="Duality.Vector3">
                          <X dataType="Float">4.76837158E-07</X>
                          <Y dataType="Float">65</Y>
                          <Z dataType="Float">0</Z>
                        </posAbs>
                        <scale dataType="Float">1</scale>
                        <scaleAbs dataType="Float">1</scaleAbs>
                        <vel dataType="Struct" type="Duality.Vector3" />
                        <velAbs dataType="Struct" type="Duality.Vector3" />
                      </item>
                      <item dataType="ObjectRef">2255617758</item>
                    </_items>
                    <_size dataType="Int">2</_size>
                    <_version dataType="Int">2</_version>
                  </compList>
                  <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1604887226" surrogate="true">
                    <header />
                    <body>
                      <keys dataType="Array" type="System.Object[]" id="1725033012">
                        <item dataType="ObjectRef">1036162158</item>
                        <item dataType="ObjectRef">4148054</item>
                      </keys>
                      <values dataType="Array" type="System.Object[]" id="2821090038">
                        <item dataType="ObjectRef">2973766122</item>
                        <item dataType="ObjectRef">2255617758</item>
                      </values>
                    </body>
                  </compMap>
                  <compTransform dataType="ObjectRef">2973766122</compTransform>
                  <identifier dataType="Struct" type="System.Guid" surrogate="true">
                    <header>
                      <data dataType="Array" type="System.Byte[]" id="3486235024">zMtiOvIpVU6L0TcGE/qFLw==</data>
                    </header>
                    <body />
                  </identifier>
                  <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
                  <name dataType="String">Limit</name>
                  <parent dataType="ObjectRef">3693600976</parent>
                  <prefabLink />
                </gameobj>
                <offset dataType="Int">0</offset>
                <pixelGrid dataType="Bool">false</pixelGrid>
                <rect dataType="Struct" type="Duality.Rect">
                  <H dataType="Float">28</H>
                  <W dataType="Float">100</W>
                  <X dataType="Float">-50</X>
                  <Y dataType="Float">-14</Y>
                </rect>
                <rectMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+UVMode" name="Stretch" value="0" />
                <sharedMat dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]">
                  <contentPath dataType="String">Default\Texture\White.Material.res</contentPath>
                </sharedMat>
                <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
              </cupLimitSpriteRenderer>
              <fillHeight dataType="Float">150</fillHeight>
              <fillSpeed dataType="Float">0.3</fillSpeed>
              <gameobj dataType="ObjectRef">3693600976</gameobj>
              <maxFillHeight dataType="Float">175</maxFillHeight>
              <waterSpriteRenderer dataType="ObjectRef">2439156493</waterSpriteRenderer>
            </activeCup>
            <gameobj dataType="ObjectRef">3114500229</gameobj>
            <hud dataType="Struct" type="FillItUp.HUD" id="1456290901">
              <_x003C_BoundRadius_x003E_k__BackingField dataType="Float">0</_x003C_BoundRadius_x003E_k__BackingField>
              <active dataType="Bool">true</active>
              <gameobj dataType="ObjectRef">3114500229</gameobj>
              <lightBeam dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Material]]" />
              <score dataType="Int">0</score>
              <scoreFont dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Font]]">
                <contentPath dataType="String">Default:Font:GenericMonospace10</contentPath>
              </scoreFont>
            </hud>
          </item>
          <item dataType="ObjectRef">1456290901</item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">2</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2390888000" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2997405501">
            <item dataType="Type" id="717507110" value="FillItUp.GameManager" />
            <item dataType="Type" id="168765114" value="FillItUp.HUD" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="302616760">
            <item dataType="ObjectRef">378336785</item>
            <item dataType="ObjectRef">1456290901</item>
          </values>
        </body>
      </compMap>
      <compTransform />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="2966318359">+MgYlrs7GEiXLRRkDtTpZQ==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">GameManager</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="ObjectRef">3693600976</item>
    <item dataType="ObjectRef">796989925</item>
    <item dataType="ObjectRef">613451190</item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
