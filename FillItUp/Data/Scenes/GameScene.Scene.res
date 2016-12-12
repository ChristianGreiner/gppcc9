<root dataType="Struct" type="Duality.Resources.Scene" id="129723834">
  <assetInfo />
  <globalGravity dataType="Struct" type="Duality.Vector2">
    <X dataType="Float">0</X>
    <Y dataType="Float">33</Y>
  </globalGravity>
  <serializeObj dataType="Array" type="Duality.GameObject[]" id="427169525">
    <item dataType="Struct" type="Duality.GameObject" id="3146122859">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3201305625">
        <_items dataType="Array" type="Duality.Component[]" id="3487452494" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="1211470495">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">3146122859</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">-80</Y>
              <Z dataType="Float">-500</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">-80</Y>
              <Z dataType="Float">-500</Z>
            </posAbs>
            <scale dataType="Float">1E-07</scale>
            <scaleAbs dataType="Float">1E-07</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Camera" id="3683398666">
            <active dataType="Bool">true</active>
            <farZ dataType="Float">10000</farZ>
            <focusDist dataType="Float">500</focusDist>
            <gameobj dataType="ObjectRef">3146122859</gameobj>
            <nearZ dataType="Float">0</nearZ>
            <passes dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Components.Camera+Pass]]" id="2506736910">
              <_items dataType="Array" type="Duality.Components.Camera+Pass[]" id="1117076944" length="4">
                <item dataType="Struct" type="Duality.Components.Camera+Pass" id="1482284732">
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
                <item dataType="Struct" type="Duality.Components.Camera+Pass" id="1133589142">
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
          <item dataType="Struct" type="Duality.Components.SoundListener" id="3799604230">
            <active dataType="Bool">true</active>
            <gameobj dataType="ObjectRef">3146122859</gameobj>
          </item>
        </_items>
        <_size dataType="Int">3</_size>
        <_version dataType="Int">3</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="772991872" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2794358579">
            <item dataType="Type" id="261085222" value="Duality.Components.Transform" />
            <item dataType="Type" id="797957818" value="Duality.Components.Camera" />
            <item dataType="Type" id="865210150" value="Duality.Components.SoundListener" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="823302840">
            <item dataType="ObjectRef">1211470495</item>
            <item dataType="ObjectRef">3683398666</item>
            <item dataType="ObjectRef">3799604230</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">1211470495</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="4102296921">vkpHGMHY1UyWqntL4s2wAA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">MainCamera</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="3854830877">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="848341679">
        <_items dataType="Array" type="Duality.Component[]" id="3303394286" length="4">
          <item dataType="Struct" type="Duality.Components.Transform" id="1920178513">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">3854830877</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">-80</Y>
              <Z dataType="Float">0</Z>
            </pos>
            <posAbs dataType="Struct" type="Duality.Vector3">
              <X dataType="Float">0</X>
              <Y dataType="Float">-80</Y>
              <Z dataType="Float">0</Z>
            </posAbs>
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
          <item dataType="Struct" type="Duality.Components.Renderers.SpriteRenderer" id="1202030149">
            <active dataType="Bool">true</active>
            <colorTint dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">255</B>
              <G dataType="Byte">255</G>
              <R dataType="Byte">255</R>
            </colorTint>
            <customMat />
            <flipMode dataType="Enum" type="Duality.Components.Renderers.SpriteRenderer+FlipMode" name="None" value="0" />
            <gameobj dataType="ObjectRef">3854830877</gameobj>
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
              <contentPath dataType="String">Data\Sprites\Cup1.Material.res</contentPath>
            </sharedMat>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
          </item>
          <item dataType="Struct" type="FillItUp.Cup" id="3573454762">
            <_x003C_BoundRadius_x003E_k__BackingField dataType="Float">0</_x003C_BoundRadius_x003E_k__BackingField>
            <active dataType="Bool">true</active>
            <coffeeColor dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">55</B>
              <G dataType="Byte">78</G>
              <R dataType="Byte">111</R>
            </coffeeColor>
            <cupBottomPosY dataType="Float">0</cupBottomPosY>
            <cupWidth dataType="Float">110</cupWidth>
            <fillingSound dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Sound]]">
              <contentPath dataType="String">Data/Audio/cup-fill.Sound.res</contentPath>
            </fillingSound>
            <fillSpeed dataType="Float">3</fillSpeed>
            <gameobj dataType="ObjectRef">3854830877</gameobj>
            <greenTeeColor dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">113</B>
              <G dataType="Byte">204</G>
              <R dataType="Byte">46</R>
            </greenTeeColor>
            <maxFillHeight dataType="Int">160</maxFillHeight>
            <rnd dataType="Struct" type="System.Random" id="1562478702">
              <inext dataType="Int">0</inext>
              <inextp dataType="Int">21</inextp>
              <SeedArray dataType="Array" type="System.Int32[]" id="769062480">0, 2130553573, 1397157678, 901639380, 264899464, 2088150892, 1929148847, 79200316, 1445137306, 1950041258, 724657242, 1456406996, 2079049659, 1196195953, 1376592897, 478773369, 1265168836, 1225580840, 948151912, 72589051, 870721859, 1344392460, 1024416022, 1767985327, 1452001835, 380472525, 2035133580, 124572116, 1049283820, 452334600, 354258323, 1011835263, 451034973, 2079020105, 741233343, 723646409, 570290377, 98187887, 919800136, 1513238108, 228600104, 1137472212, 2049337186, 1388260468, 282401153, 1104793560, 1600522496, 1333211529, 2083115145, 1308298814, 481789801, 939222152, 56095660, 83285003, 1327671510, 1774090881</SeedArray>
            </rnd>
            <showDebug dataType="Bool">false</showDebug>
            <showLimit dataType="Bool">true</showLimit>
            <sodaColor dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">15</B>
              <G dataType="Byte">196</G>
              <R dataType="Byte">241</R>
            </sodaColor>
            <successSound dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Sound]]">
              <contentPath dataType="String">Data/Audio/success.Sound.res</contentPath>
            </successSound>
            <visibilityGroup dataType="Enum" type="Duality.Drawing.VisibilityFlag" name="Group0" value="1" />
            <waterColor dataType="Struct" type="Duality.Drawing.ColorRgba">
              <A dataType="Byte">255</A>
              <B dataType="Byte">219</B>
              <G dataType="Byte">152</G>
              <R dataType="Byte">52</R>
            </waterColor>
          </item>
        </_items>
        <_size dataType="Int">3</_size>
        <_version dataType="Int">3</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="3421428896" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="1390476677">
            <item dataType="ObjectRef">261085222</item>
            <item dataType="Type" id="50393430" value="Duality.Components.Renderers.SpriteRenderer" />
            <item dataType="Type" id="774308058" value="FillItUp.Cup" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="4155480744">
            <item dataType="ObjectRef">1920178513</item>
            <item dataType="ObjectRef">1202030149</item>
            <item dataType="ObjectRef">3573454762</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">1920178513</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="1884395151">s0rBGAWpt0eAIFQlEtVdGQ==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">Cup</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="3360831770">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="3804517700">
        <_items dataType="Array" type="Duality.Component[]" id="3187794500" length="4">
          <item dataType="Struct" type="FillItUp.GameManager" id="624668326">
            <active dataType="Bool">true</active>
            <activeCup dataType="ObjectRef">3573454762</activeCup>
            <camera dataType="ObjectRef">3146122859</camera>
            <comboSound dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Sound]]">
              <contentPath dataType="String">Data/Audio/combo.Sound.res</contentPath>
            </comboSound>
            <gameobj dataType="ObjectRef">3360831770</gameobj>
            <rnd dataType="Struct" type="System.Random" id="1214541854">
              <inext dataType="Int">0</inext>
              <inextp dataType="Int">21</inextp>
              <SeedArray dataType="Array" type="System.Int32[]" id="2256942736">0, 1396124166, 194244046, 689857661, 2103764798, 183910857, 1060869109, 1593161711, 1077672487, 1830020549, 538772290, 65055585, 1170389530, 56854287, 1287823332, 1063987165, 566623905, 1263872112, 938295888, 641583629, 1480494036, 173119916, 1651489449, 1503328935, 722979736, 334281411, 438828593, 2055601917, 823578800, 1292325961, 1893243678, 728593391, 434014237, 516850410, 1639739708, 1659228044, 305225134, 790349946, 776007328, 863024004, 659673570, 1829126931, 613830054, 1228312614, 492258160, 34943516, 829413875, 1141045644, 1181677508, 875153873, 1880622556, 1405840754, 1353000255, 805415084, 1498290065, 1375988922</SeedArray>
            </rnd>
            <tickingSound dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Sound]]">
              <contentPath dataType="String">Data/Audio/ticking-clock.Sound.res</contentPath>
            </tickingSound>
            <tickingSoundInstance />
            <timeSlowdown dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Sound]]">
              <contentPath dataType="String">Data/Audio/time-slowdown.Sound.res</contentPath>
            </timeSlowdown>
            <timeSpeedup dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Sound]]">
              <contentPath dataType="String">Data/Audio/time-speedup.Sound.res</contentPath>
            </timeSpeedup>
          </item>
        </_items>
        <_size dataType="Int">1</_size>
        <_version dataType="Int">1</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="2266325654" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="2232509646">
            <item dataType="Type" id="1966137296" value="FillItUp.GameManager" />
          </keys>
          <values dataType="Array" type="System.Object[]" id="1701949258">
            <item dataType="ObjectRef">624668326</item>
          </values>
        </body>
      </compMap>
      <compTransform />
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="1763154558">tnSIB9oU1E2dq9tZ5PhqeA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">GameManager</name>
      <parent />
      <prefabLink />
    </item>
    <item dataType="Struct" type="Duality.GameObject" id="2193707266">
      <active dataType="Bool">true</active>
      <children />
      <compList dataType="Struct" type="System.Collections.Generic.List`1[[Duality.Component]]" id="537455116">
        <_items dataType="Array" type="Duality.Component[]" id="864089252" length="4">
          <item dataType="Struct" type="FillItUp.Hud" id="3243919250">
            <_x003C_BoundRadius_x003E_k__BackingField dataType="Float">0</_x003C_BoundRadius_x003E_k__BackingField>
            <active dataType="Bool">true</active>
            <comboCounterText dataType="Struct" type="Duality.Drawing.FormattedText" id="2737617858">
              <flowAreas />
              <fonts dataType="Array" type="Duality.ContentRef`1[[Duality.Resources.Font]][]" id="4008236560">
                <item dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Font]]">
                  <contentPath dataType="String">Default:Font:GenericMonospace10</contentPath>
                </item>
              </fonts>
              <icons />
              <lineAlign dataType="Enum" type="Duality.Alignment" name="Left" value="1" />
              <maxHeight dataType="Int">0</maxHeight>
              <maxWidth dataType="Int">0</maxWidth>
              <sourceText />
              <wrapMode dataType="Enum" type="Duality.Drawing.FormattedText+WrapMode" name="Word" value="1" />
            </comboCounterText>
            <countdownText dataType="Struct" type="Duality.Drawing.FormattedText" id="1177466378">
              <flowAreas />
              <fonts dataType="Array" type="Duality.ContentRef`1[[Duality.Resources.Font]][]" id="3405129112">
                <item dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Font]]">
                  <contentPath dataType="String">Default:Font:GenericMonospace10</contentPath>
                </item>
              </fonts>
              <icons />
              <lineAlign dataType="Enum" type="Duality.Alignment" name="Left" value="1" />
              <maxHeight dataType="Int">0</maxHeight>
              <maxWidth dataType="Int">0</maxWidth>
              <sourceText />
              <wrapMode dataType="Enum" type="Duality.Drawing.FormattedText+WrapMode" name="Word" value="1" />
            </countdownText>
            <gameManager dataType="ObjectRef">624668326</gameManager>
            <gameobj dataType="ObjectRef">2193707266</gameobj>
            <gameStartTimerText dataType="Struct" type="Duality.Drawing.FormattedText" id="2719895218">
              <flowAreas />
              <fonts dataType="Array" type="Duality.ContentRef`1[[Duality.Resources.Font]][]" id="2278099104">
                <item dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Font]]">
                  <contentPath dataType="String">Default:Font:GenericMonospace10</contentPath>
                </item>
              </fonts>
              <icons />
              <lineAlign dataType="Enum" type="Duality.Alignment" name="Left" value="1" />
              <maxHeight dataType="Int">0</maxHeight>
              <maxWidth dataType="Int">0</maxWidth>
              <sourceText dataType="String">4</sourceText>
              <wrapMode dataType="Enum" type="Duality.Drawing.FormattedText+WrapMode" name="Word" value="1" />
            </gameStartTimerText>
            <textFont dataType="Struct" type="Duality.ContentRef`1[[Duality.Resources.Font]]">
              <contentPath dataType="String">Data\Fonts\OpenSans.Font.res</contentPath>
            </textFont>
          </item>
          <item dataType="Struct" type="Duality.Components.Transform" id="259054902">
            <active dataType="Bool">true</active>
            <angle dataType="Float">0</angle>
            <angleAbs dataType="Float">0</angleAbs>
            <angleVel dataType="Float">0</angleVel>
            <angleVelAbs dataType="Float">0</angleVelAbs>
            <deriveAngle dataType="Bool">true</deriveAngle>
            <gameobj dataType="ObjectRef">2193707266</gameobj>
            <ignoreParent dataType="Bool">false</ignoreParent>
            <parentTransform />
            <pos dataType="Struct" type="Duality.Vector3" />
            <posAbs dataType="Struct" type="Duality.Vector3" />
            <scale dataType="Float">1</scale>
            <scaleAbs dataType="Float">1</scaleAbs>
            <vel dataType="Struct" type="Duality.Vector3" />
            <velAbs dataType="Struct" type="Duality.Vector3" />
          </item>
        </_items>
        <_size dataType="Int">2</_size>
        <_version dataType="Int">4</_version>
      </compList>
      <compMap dataType="Struct" type="System.Collections.Generic.Dictionary`2[[System.Type],[Duality.Component]]" id="1883554550" surrogate="true">
        <header />
        <body>
          <keys dataType="Array" type="System.Object[]" id="637131398">
            <item dataType="Type" id="2480619392" value="FillItUp.Hud" />
            <item dataType="ObjectRef">261085222</item>
          </keys>
          <values dataType="Array" type="System.Object[]" id="4079361850">
            <item dataType="ObjectRef">3243919250</item>
            <item dataType="ObjectRef">259054902</item>
          </values>
        </body>
      </compMap>
      <compTransform dataType="ObjectRef">259054902</compTransform>
      <identifier dataType="Struct" type="System.Guid" surrogate="true">
        <header>
          <data dataType="Array" type="System.Byte[]" id="1511034374">EBN/UL6JdkKK6FsW9cF7ZA==</data>
        </header>
        <body />
      </identifier>
      <initState dataType="Enum" type="Duality.InitState" name="Initialized" value="1" />
      <name dataType="String">Hud</name>
      <parent />
      <prefabLink />
    </item>
  </serializeObj>
  <visibilityStrategy dataType="Struct" type="Duality.Components.DefaultRendererVisibilityStrategy" id="2035693768" />
</root>
<!-- XmlFormatterBase Document Separator -->
