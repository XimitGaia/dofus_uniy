using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000B1E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PaddockInformation : IMessage<PaddockInformation>, IMessage, IEquatable<PaddockInformation>, IDeepCloneable<PaddockInformation>, IBufferMessage
{
	[Token(Token = "0x2000B1F")]
	public enum InformationOneofCase
	{
		[Token(Token = "0x400299C")]
		None = 0,
		[Token(Token = "0x400299D")]
		Content = 3,
		[Token(Token = "0x400299E")]
		Instances = 4
	}

	[Token(Token = "0x2000B20")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000B21")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PaddockContent : IMessage<PaddockContent>, IMessage, IEquatable<PaddockContent>, IDeepCloneable<PaddockContent>, IBufferMessage
		{
			[Token(Token = "0x2000B22")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static class Types
			{
				[Token(Token = "0x2000B23")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class MountForPaddock : IMessage<MountForPaddock>, IMessage, IEquatable<MountForPaddock>, IDeepCloneable<MountForPaddock>, IBufferMessage
				{
					[Token(Token = "0x40029AA")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<MountForPaddock> _parser;

					[Token(Token = "0x40029AB")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40029AC")]
					public const int ModelIdFieldNumber = 1;

					[Token(Token = "0x40029AD")]
					[FieldOffset(Offset = "0x18")]
					private int modelId_;

					[Token(Token = "0x40029AE")]
					public const int NameFieldNumber = 2;

					[Token(Token = "0x40029AF")]
					[FieldOffset(Offset = "0x20")]
					private string name_;

					[Token(Token = "0x40029B0")]
					public const int OwnerNameFieldNumber = 3;

					[Token(Token = "0x40029B1")]
					[FieldOffset(Offset = "0x28")]
					private string ownerName_;

					[Token(Token = "0x170019E3")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public static MessageParser<MountForPaddock> Parser
					{
						[Token(Token = "0x600756F")]
						[Address(RVA = "0xC06310", Offset = "0xC05710", VA = "0x180C06310")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170019E4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x6007570")]
						[Address(RVA = "0xC06290", Offset = "0xC05690", VA = "0x180C06290")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170019E5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x6007571")]
						[Address(RVA = "0xC06470", Offset = "0xC05870", VA = "0x180C06470", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170019E6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int ModelId
					{
						[Token(Token = "0x6007575")]
						[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
						get
						{
							return default(int);
						}
						[Token(Token = "0x6007576")]
						[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
						set
						{
						}
					}

					[Token(Token = "0x170019E7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public string Name
					{
						[Token(Token = "0x6007577")]
						[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
						get
						{
							return null;
						}
						[Token(Token = "0x6007578")]
						[Address(RVA = "0xC06520", Offset = "0xC05920", VA = "0x180C06520")]
						set
						{
						}
					}

					[Token(Token = "0x170019E8")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public string OwnerName
					{
						[Token(Token = "0x6007579")]
						[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
						get
						{
							return null;
						}
						[Token(Token = "0x600757A")]
						[Address(RVA = "0xC06590", Offset = "0xC05990", VA = "0x180C06590")]
						set
						{
						}
					}

					[Token(Token = "0x6007572")]
					[Address(RVA = "0xC06140", Offset = "0xC05540", VA = "0x180C06140")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public MountForPaddock()
					{
					}

					[Token(Token = "0x6007573")]
					[Address(RVA = "0xC061B0", Offset = "0xC055B0", VA = "0x180C061B0")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public MountForPaddock(MountForPaddock other)
					{
					}

					[Token(Token = "0x6007574")]
					[Address(RVA = "0xC05D70", Offset = "0xC05170", VA = "0x180C05D70", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public MountForPaddock Clone()
					{
						return null;
					}

					[Token(Token = "0x600757B")]
					[Address(RVA = "0xC05E80", Offset = "0xC05280", VA = "0x180C05E80", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x600757C")]
					[Address(RVA = "0x97E1F0", Offset = "0x97D5F0", VA = "0x18097E1F0", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(MountForPaddock other)
					{
						return default(bool);
					}

					[Token(Token = "0x600757D")]
					[Address(RVA = "0x97E340", Offset = "0x97D740", VA = "0x18097E340", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x600757E")]
					[Address(RVA = "0xC05FE0", Offset = "0xC053E0", VA = "0x180C05FE0", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x600757F")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x6007580")]
					[Address(RVA = "0x97E940", Offset = "0x97DD40", VA = "0x18097E940", Slot = "12")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x6007581")]
					[Address(RVA = "0xC05C80", Offset = "0xC05080", VA = "0x180C05C80", Slot = "7")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x6007582")]
					[Address(RVA = "0xC05F50", Offset = "0xC05350", VA = "0x180C05F50", Slot = "4")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(MountForPaddock other)
					{
					}

					[Token(Token = "0x6007583")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x6007584")]
					[Address(RVA = "0xC06360", Offset = "0xC05760", VA = "0x180C06360", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x400299F")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PaddockContent> _parser;

			[Token(Token = "0x40029A0")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40029A1")]
			public const int PaddockIdFieldNumber = 1;

			[Token(Token = "0x40029A2")]
			[FieldOffset(Offset = "0x18")]
			private long paddockId_;

			[Token(Token = "0x40029A3")]
			public const int CoordinatesFieldNumber = 2;

			[Token(Token = "0x40029A4")]
			[FieldOffset(Offset = "0x20")]
			private MapExtendedCoordinates coordinates_;

			[Token(Token = "0x40029A5")]
			public const int AbandonedFieldNumber = 3;

			[Token(Token = "0x40029A6")]
			[FieldOffset(Offset = "0x28")]
			private bool abandoned_;

			[Token(Token = "0x40029A7")]
			public const int MountsInformationFieldNumber = 4;

			[Token(Token = "0x40029A8")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<Types.MountForPaddock> _repeated_mountsInformation_codec;

			[Token(Token = "0x40029A9")]
			[FieldOffset(Offset = "0x30")]
			private readonly RepeatedField<Types.MountForPaddock> mountsInformation_;

			[Token(Token = "0x170019DC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<PaddockContent> Parser
			{
				[Token(Token = "0x6007557")]
				[Address(RVA = "0xC07460", Offset = "0xC06860", VA = "0x180C07460")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170019DD")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6007558")]
				[Address(RVA = "0xC073E0", Offset = "0xC067E0", VA = "0x180C073E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170019DE")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6007559")]
				[Address(RVA = "0xC07790", Offset = "0xC06B90", VA = "0x180C07790", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170019DF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public long PaddockId
			{
				[Token(Token = "0x600755D")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return default(long);
				}
				[Token(Token = "0x600755E")]
				[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
				set
				{
				}
			}

			[Token(Token = "0x170019E0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public MapExtendedCoordinates Coordinates
			{
				[Token(Token = "0x600755F")]
				[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
				get
				{
					return null;
				}
				[Token(Token = "0x6007560")]
				[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
				set
				{
				}
			}

			[Token(Token = "0x170019E1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Abandoned
			{
				[Token(Token = "0x6007561")]
				[Address(RVA = "0x8529D0", Offset = "0x851DD0", VA = "0x1808529D0")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6007562")]
				[Address(RVA = "0x9A1E80", Offset = "0x9A1280", VA = "0x1809A1E80")]
				set
				{
				}
			}

			[Token(Token = "0x170019E2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RepeatedField<Types.MountForPaddock> MountsInformation
			{
				[Token(Token = "0x6007563")]
				[Address(RVA = "0x871BB0", Offset = "0x870FB0", VA = "0x180871BB0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600755A")]
			[Address(RVA = "0xC07360", Offset = "0xC06760", VA = "0x180C07360")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PaddockContent()
			{
			}

			[Token(Token = "0x600755B")]
			[Address(RVA = "0xC072A0", Offset = "0xC066A0", VA = "0x180C072A0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockContent(PaddockContent other)
			{
			}

			[Token(Token = "0x600755C")]
			[Address(RVA = "0xC06BE0", Offset = "0xC05FE0", VA = "0x180C06BE0", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockContent Clone()
			{
				return null;
			}

			[Token(Token = "0x6007564")]
			[Address(RVA = "0xC06CD0", Offset = "0xC060D0", VA = "0x180C06CD0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007565")]
			[Address(RVA = "0xC06DD0", Offset = "0xC061D0", VA = "0x180C06DD0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PaddockContent other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007566")]
			[Address(RVA = "0xC06E90", Offset = "0xC06290", VA = "0x180C06E90", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007567")]
			[Address(RVA = "0xC070A0", Offset = "0xC064A0", VA = "0x180C070A0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007568")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007569")]
			[Address(RVA = "0xC07670", Offset = "0xC06A70", VA = "0x180C07670", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600756A")]
			[Address(RVA = "0xC06AC0", Offset = "0xC05EC0", VA = "0x180C06AC0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600756B")]
			[Address(RVA = "0xC06F90", Offset = "0xC06390", VA = "0x180C06F90", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(PaddockContent other)
			{
			}

			[Token(Token = "0x600756C")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600756D")]
			[Address(RVA = "0xC074B0", Offset = "0xC068B0", VA = "0x180C074B0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000B26")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class PaddockInstances : IMessage<PaddockInstances>, IMessage, IEquatable<PaddockInstances>, IDeepCloneable<PaddockInstances>, IBufferMessage
		{
			[Token(Token = "0x2000B27")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static class Types
			{
				[Token(Token = "0x2000B28")]
				[DebuggerDisplay("{ToString(),nq}")]
				public sealed class PaddockToSell : IMessage<PaddockToSell>, IMessage, IEquatable<PaddockToSell>, IDeepCloneable<PaddockToSell>, IBufferMessage
				{
					[Token(Token = "0x2000B29")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static class Types
					{
						[Token(Token = "0x2000B2A")]
						[DebuggerDisplay("{ToString(),nq}")]
						public sealed class PaddockGuildInformation : IMessage<PaddockGuildInformation>, IMessage, IEquatable<PaddockGuildInformation>, IDeepCloneable<PaddockGuildInformation>, IBufferMessage
						{
							[Token(Token = "0x40029C1")]
							[FieldOffset(Offset = "0x0")]
							private static readonly MessageParser<PaddockGuildInformation> _parser;

							[Token(Token = "0x40029C2")]
							[FieldOffset(Offset = "0x10")]
							private UnknownFieldSet _unknownFields;

							[Token(Token = "0x40029C3")]
							public const int DesertedFieldNumber = 1;

							[Token(Token = "0x40029C4")]
							[FieldOffset(Offset = "0x18")]
							private bool deserted_;

							[Token(Token = "0x40029C5")]
							public const int GuildInformationFieldNumber = 2;

							[Token(Token = "0x40029C6")]
							[FieldOffset(Offset = "0x20")]
							private GuildInformation guildInformation_;

							[Token(Token = "0x170019F3")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public static MessageParser<PaddockGuildInformation> Parser
							{
								[Token(Token = "0x60075B5")]
								[Address(RVA = "0xC07D40", Offset = "0xC07140", VA = "0x180C07D40")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170019F4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public static MessageDescriptor Descriptor
							{
								[Token(Token = "0x60075B6")]
								[Address(RVA = "0xC07CC0", Offset = "0xC070C0", VA = "0x180C07CC0")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170019F5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
							{
								[Token(Token = "0x60075B7")]
								[Address(RVA = "0xC07EC0", Offset = "0xC072C0", VA = "0x180C07EC0", Slot = "8")]
								get
								{
									return null;
								}
							}

							[Token(Token = "0x170019F6")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public bool Deserted
							{
								[Token(Token = "0x60075BB")]
								[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
								get
								{
									return default(bool);
								}
								[Token(Token = "0x60075BC")]
								[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
								set
								{
								}
							}

							[Token(Token = "0x170019F7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public GuildInformation GuildInformation
							{
								[Token(Token = "0x60075BD")]
								[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
								get
								{
									return null;
								}
								[Token(Token = "0x60075BE")]
								[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
								set
								{
								}
							}

							[Token(Token = "0x60075B8")]
							[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public PaddockGuildInformation()
							{
							}

							[Token(Token = "0x60075B9")]
							[Address(RVA = "0x9FEF90", Offset = "0x9FE390", VA = "0x1809FEF90")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public PaddockGuildInformation(PaddockGuildInformation other)
							{
							}

							[Token(Token = "0x60075BA")]
							[Address(RVA = "0xC07870", Offset = "0xC06C70", VA = "0x180C07870", Slot = "10")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public PaddockGuildInformation Clone()
							{
								return null;
							}

							[Token(Token = "0x60075BF")]
							[Address(RVA = "0xC07910", Offset = "0xC06D10", VA = "0x180C07910", Slot = "0")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override bool Equals(object other)
							{
								return default(bool);
							}

							[Token(Token = "0x60075C0")]
							[Address(RVA = "0x9742A0", Offset = "0x9736A0", VA = "0x1809742A0", Slot = "9")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public bool Equals(PaddockGuildInformation other)
							{
								return default(bool);
							}

							[Token(Token = "0x60075C1")]
							[Address(RVA = "0xC079C0", Offset = "0xC06DC0", VA = "0x180C079C0", Slot = "2")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override int GetHashCode()
							{
								return default(int);
							}

							[Token(Token = "0x60075C2")]
							[Address(RVA = "0xC07B60", Offset = "0xC06F60", VA = "0x180C07B60", Slot = "3")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public override string ToString()
							{
								return null;
							}

							[Token(Token = "0x60075C3")]
							[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void WriteTo(CodedOutputStream output)
							{
							}

							[Token(Token = "0x60075C4")]
							[Address(RVA = "0x9749C0", Offset = "0x973DC0", VA = "0x1809749C0", Slot = "12")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
							{
							}

							[Token(Token = "0x60075C5")]
							[Address(RVA = "0xC077D0", Offset = "0xC06BD0", VA = "0x180C077D0", Slot = "7")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public int CalculateSize()
							{
								return default(int);
							}

							[Token(Token = "0x60075C6")]
							[Address(RVA = "0xC07A80", Offset = "0xC06E80", VA = "0x180C07A80", Slot = "4")]
							[DebuggerNonUserCode]
							[GeneratedCode("protoc", null)]
							public void MergeFrom(PaddockGuildInformation other)
							{
							}

							[Token(Token = "0x60075C7")]
							[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							public void MergeFrom(CodedInputStream input)
							{
							}

							[Token(Token = "0x60075C8")]
							[Address(RVA = "0xC07D90", Offset = "0xC07190", VA = "0x180C07D90", Slot = "11")]
							[GeneratedCode("protoc", null)]
							[DebuggerNonUserCode]
							private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
							{
							}
						}
					}

					[Token(Token = "0x40029B9")]
					[FieldOffset(Offset = "0x0")]
					private static readonly MessageParser<PaddockToSell> _parser;

					[Token(Token = "0x40029BA")]
					[FieldOffset(Offset = "0x10")]
					private UnknownFieldSet _unknownFields;

					[Token(Token = "0x40029BB")]
					public const int PriceFieldNumber = 1;

					[Token(Token = "0x40029BC")]
					[FieldOffset(Offset = "0x18")]
					private long price_;

					[Token(Token = "0x40029BD")]
					public const int LockedFieldNumber = 2;

					[Token(Token = "0x40029BE")]
					[FieldOffset(Offset = "0x20")]
					private bool locked_;

					[Token(Token = "0x40029BF")]
					public const int GuildInformationFieldNumber = 3;

					[Token(Token = "0x40029C0")]
					[FieldOffset(Offset = "0x28")]
					private Types.PaddockGuildInformation guildInformation_;

					[Token(Token = "0x170019ED")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageParser<PaddockToSell> Parser
					{
						[Token(Token = "0x600759E")]
						[Address(RVA = "0xC0A270", Offset = "0xC09670", VA = "0x180C0A270")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170019EE")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public static MessageDescriptor Descriptor
					{
						[Token(Token = "0x600759F")]
						[Address(RVA = "0xC0A1F0", Offset = "0xC095F0", VA = "0x180C0A1F0")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170019EF")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
					{
						[Token(Token = "0x60075A0")]
						[Address(RVA = "0xC0A4B0", Offset = "0xC098B0", VA = "0x180C0A4B0", Slot = "8")]
						get
						{
							return null;
						}
					}

					[Token(Token = "0x170019F0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public long Price
					{
						[Token(Token = "0x60075A4")]
						[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
						get
						{
							return default(long);
						}
						[Token(Token = "0x60075A5")]
						[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
						set
						{
						}
					}

					[Token(Token = "0x170019F1")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Locked
					{
						[Token(Token = "0x60075A6")]
						[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
						get
						{
							return default(bool);
						}
						[Token(Token = "0x60075A7")]
						[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
						set
						{
						}
					}

					[Token(Token = "0x170019F2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public Types.PaddockGuildInformation GuildInformation
					{
						[Token(Token = "0x60075A8")]
						[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
						get
						{
							return null;
						}
						[Token(Token = "0x60075A9")]
						[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
						set
						{
						}
					}

					[Token(Token = "0x60075A1")]
					[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public PaddockToSell()
					{
					}

					[Token(Token = "0x60075A2")]
					[Address(RVA = "0xC0A0E0", Offset = "0xC094E0", VA = "0x180C0A0E0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public PaddockToSell(PaddockToSell other)
					{
					}

					[Token(Token = "0x60075A3")]
					[Address(RVA = "0xC09A90", Offset = "0xC08E90", VA = "0x180C09A90", Slot = "10")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public PaddockToSell Clone()
					{
						return null;
					}

					[Token(Token = "0x60075AA")]
					[Address(RVA = "0xC09C50", Offset = "0xC09050", VA = "0x180C09C50", Slot = "0")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override bool Equals(object other)
					{
						return default(bool);
					}

					[Token(Token = "0x60075AB")]
					[Address(RVA = "0xC09BD0", Offset = "0xC08FD0", VA = "0x180C09BD0", Slot = "9")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public bool Equals(PaddockToSell other)
					{
						return default(bool);
					}

					[Token(Token = "0x60075AC")]
					[Address(RVA = "0xC09D10", Offset = "0xC09110", VA = "0x180C09D10", Slot = "2")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public override int GetHashCode()
					{
						return default(int);
					}

					[Token(Token = "0x60075AD")]
					[Address(RVA = "0xC09F80", Offset = "0xC09380", VA = "0x180C09F80", Slot = "3")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public override string ToString()
					{
						return null;
					}

					[Token(Token = "0x60075AE")]
					[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void WriteTo(CodedOutputStream output)
					{
					}

					[Token(Token = "0x60075AF")]
					[Address(RVA = "0xC0A410", Offset = "0xC09810", VA = "0x180C0A410", Slot = "12")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
					{
					}

					[Token(Token = "0x60075B0")]
					[Address(RVA = "0xC099C0", Offset = "0xC08DC0", VA = "0x180C099C0", Slot = "7")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public int CalculateSize()
					{
						return default(int);
					}

					[Token(Token = "0x60075B1")]
					[Address(RVA = "0xC09DF0", Offset = "0xC091F0", VA = "0x180C09DF0", Slot = "4")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					public void MergeFrom(PaddockToSell other)
					{
					}

					[Token(Token = "0x60075B2")]
					[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
					[GeneratedCode("protoc", null)]
					[DebuggerNonUserCode]
					public void MergeFrom(CodedInputStream input)
					{
					}

					[Token(Token = "0x60075B3")]
					[Address(RVA = "0xC0A2C0", Offset = "0xC096C0", VA = "0x180C0A2C0", Slot = "11")]
					[DebuggerNonUserCode]
					[GeneratedCode("protoc", null)]
					private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
					{
					}
				}
			}

			[Token(Token = "0x40029B4")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<PaddockInstances> _parser;

			[Token(Token = "0x40029B5")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x40029B6")]
			public const int PaddocksToSellFieldNumber = 1;

			[Token(Token = "0x40029B7")]
			[FieldOffset(Offset = "0x8")]
			private static readonly FieldCodec<Types.PaddockToSell> _repeated_paddocksToSell_codec;

			[Token(Token = "0x40029B8")]
			[FieldOffset(Offset = "0x18")]
			private readonly RepeatedField<Types.PaddockToSell> paddocksToSell_;

			[Token(Token = "0x170019E9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<PaddockInstances> Parser
			{
				[Token(Token = "0x600758C")]
				[Address(RVA = "0xC09770", Offset = "0xC08B70", VA = "0x180C09770")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170019EA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600758D")]
				[Address(RVA = "0xC096F0", Offset = "0xC08AF0", VA = "0x180C096F0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170019EB")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600758E")]
				[Address(RVA = "0xC09980", Offset = "0xC08D80", VA = "0x180C09980", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170019EC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RepeatedField<Types.PaddockToSell> PaddocksToSell
			{
				[Token(Token = "0x6007592")]
				[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600758F")]
			[Address(RVA = "0xC09670", Offset = "0xC08A70", VA = "0x180C09670")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PaddockInstances()
			{
			}

			[Token(Token = "0x6007590")]
			[Address(RVA = "0xC095E0", Offset = "0xC089E0", VA = "0x180C095E0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public PaddockInstances(PaddockInstances other)
			{
			}

			[Token(Token = "0x6007591")]
			[Address(RVA = "0xC09130", Offset = "0xC08530", VA = "0x180C09130", Slot = "10")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public PaddockInstances Clone()
			{
				return null;
			}

			[Token(Token = "0x6007593")]
			[Address(RVA = "0xC091F0", Offset = "0xC085F0", VA = "0x180C091F0", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007594")]
			[Address(RVA = "0xC092D0", Offset = "0xC086D0", VA = "0x180C092D0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(PaddockInstances other)
			{
				return default(bool);
			}

			[Token(Token = "0x6007595")]
			[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6007596")]
			[Address(RVA = "0xC093E0", Offset = "0xC087E0", VA = "0x180C093E0", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6007597")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6007598")]
			[Address(RVA = "0xC098D0", Offset = "0xC08CD0", VA = "0x180C098D0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6007599")]
			[Address(RVA = "0xC09090", Offset = "0xC08490", VA = "0x180C09090", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600759A")]
			[Address(RVA = "0xC09360", Offset = "0xC08760", VA = "0x180C09360", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(PaddockInstances other)
			{
			}

			[Token(Token = "0x600759B")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600759C")]
			[Address(RVA = "0xC097C0", Offset = "0xC08BC0", VA = "0x180C097C0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4002991")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PaddockInformation> _parser;

	[Token(Token = "0x4002992")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002993")]
	public const int MaxOutdoorMountFieldNumber = 1;

	[Token(Token = "0x4002994")]
	[FieldOffset(Offset = "0x18")]
	private int maxOutdoorMount_;

	[Token(Token = "0x4002995")]
	public const int MaxItemsFieldNumber = 2;

	[Token(Token = "0x4002996")]
	[FieldOffset(Offset = "0x1C")]
	private int maxItems_;

	[Token(Token = "0x4002997")]
	public const int ContentFieldNumber = 3;

	[Token(Token = "0x4002998")]
	public const int InstancesFieldNumber = 4;

	[Token(Token = "0x4002999")]
	[FieldOffset(Offset = "0x20")]
	private object information_;

	[Token(Token = "0x400299A")]
	[FieldOffset(Offset = "0x28")]
	private InformationOneofCase informationCase_;

	[Token(Token = "0x170019D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PaddockInformation> Parser
	{
		[Token(Token = "0x600753C")]
		[Address(RVA = "0xC08CD0", Offset = "0xC080D0", VA = "0x180C08CD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600753D")]
		[Address(RVA = "0xC08BC0", Offset = "0xC07FC0", VA = "0x180C08BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019D6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600753E")]
		[Address(RVA = "0xC09050", Offset = "0xC08450", VA = "0x180C09050", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170019D7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxOutdoorMount
	{
		[Token(Token = "0x6007542")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007543")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170019D8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MaxItems
	{
		[Token(Token = "0x6007544")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007545")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170019D9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PaddockContent Content
	{
		[Token(Token = "0x6007546")]
		[Address(RVA = "0xC08B60", Offset = "0xC07F60", VA = "0x180C08B60")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007547")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x170019DA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.PaddockInstances Instances
	{
		[Token(Token = "0x6007548")]
		[Address(RVA = "0xC08C70", Offset = "0xC08070", VA = "0x180C08C70")]
		get
		{
			return null;
		}
		[Token(Token = "0x6007549")]
		[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
		set
		{
		}
	}

	[Token(Token = "0x170019DB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InformationOneofCase InformationCase
	{
		[Token(Token = "0x600754A")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(InformationOneofCase);
		}
	}

	[Token(Token = "0x600753F")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PaddockInformation()
	{
	}

	[Token(Token = "0x6007540")]
	[Address(RVA = "0xC08890", Offset = "0xC07C90", VA = "0x180C08890")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockInformation(PaddockInformation other)
	{
	}

	[Token(Token = "0x6007541")]
	[Address(RVA = "0xC08100", Offset = "0xC07500", VA = "0x180C08100", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PaddockInformation Clone()
	{
		return null;
	}

	[Token(Token = "0x600754B")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void ClearInformation()
	{
	}

	[Token(Token = "0x600754C")]
	[Address(RVA = "0xC08240", Offset = "0xC07640", VA = "0x180C08240", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600754D")]
	[Address(RVA = "0xC08160", Offset = "0xC07560", VA = "0x180C08160", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PaddockInformation other)
	{
		return default(bool);
	}

	[Token(Token = "0x600754E")]
	[Address(RVA = "0xC08360", Offset = "0xC07760", VA = "0x180C08360", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600754F")]
	[Address(RVA = "0xC08730", Offset = "0xC07B30", VA = "0x180C08730", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007550")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007551")]
	[Address(RVA = "0xC08F00", Offset = "0xC08300", VA = "0x180C08F00", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007552")]
	[Address(RVA = "0xC07F70", Offset = "0xC07370", VA = "0x180C07F70", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007553")]
	[Address(RVA = "0xC084C0", Offset = "0xC078C0", VA = "0x180C084C0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(PaddockInformation other)
	{
	}

	[Token(Token = "0x6007554")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007555")]
	[Address(RVA = "0xC08D20", Offset = "0xC08120", VA = "0x180C08D20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
